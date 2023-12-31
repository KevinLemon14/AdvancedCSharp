﻿using ReservRoom.Exceptions;
using ReservRoom.Models;
using ReservRoom.Services;
using ReservRoom.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReservRoom.Commands
{
	public class MakeReservationCommand : CommandBase
	{
		private readonly MakeReservationViewModel _makeReservationViewModel;
		private readonly Hotel _hotel;
		private readonly NavigationService _resevationViewNavigationService;

		public MakeReservationCommand(MakeReservationViewModel makeReservationViewModel, 
			Hotel hotel,
			NavigationService resevationViewNavigationService)
		{
			_hotel = hotel;
			_resevationViewNavigationService = resevationViewNavigationService;
			_makeReservationViewModel = makeReservationViewModel;

			_makeReservationViewModel.PropertyChanged += OnViewModelPropertyChanged;
		}

		public override bool CanExecute(object? parameter)
		{
			return !string.IsNullOrEmpty(_makeReservationViewModel.Username) && 
				_makeReservationViewModel.FloorNumber > 0 &&
				base.CanExecute(parameter);
		}

		public override void Execute(object? parameter)
		{
			Reservation reservation = new Reservation(
				new RoomID(_makeReservationViewModel.FloorNumber, _makeReservationViewModel.RoomNumber),
				_makeReservationViewModel.Username,
				_makeReservationViewModel.StartDate,
				_makeReservationViewModel.EndDate);

			try
			{
				_hotel.MakeReservation(reservation);

				MessageBox.Show("Congratulations! Your room is reserved.", "Success",
					MessageBoxButton.OK, MessageBoxImage.Information);

				_resevationViewNavigationService.Navigate();
			}
			catch (ReservationConflictException)
			{
				MessageBox.Show("This room is unavailable during the selected dates.", "Error", 
					MessageBoxButton.OK, MessageBoxImage.Error);
			}
			
		}

		private void OnViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			if(e.PropertyName == nameof(MakeReservationViewModel.Username) ||
				e.PropertyName == nameof(MakeReservationViewModel.FloorNumber))
			{
				OnCanExecuteChanged();
			}
		}
	}
}
