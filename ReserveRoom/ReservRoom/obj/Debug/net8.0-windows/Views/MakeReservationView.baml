   M S B A M L   `   `   `  ����E  AReservRoom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:ReservRoom.ViewsReservRoom.Views  5      *    $ReservRoom.Views.MakeReservationView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:ReservRoom.Views     5      .��5      �   � IsSharedSizeScope$
  True��5   	    � RowDefinitions 5   
   �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      �� 5      $
��auto �5      .+�5   
   �� $��0��5       
  Header#��[  5      $��Make Reservation��5      � 5   
   $��1��5      $��0 25 0 0q�5       5       �� 5!      $
��auto �5"      �� 5#      $
��auto �5$      .+�5'      �� $��0��5(      $��Userame��5)      �� 5*      $��1��5+      $��0 5 0 0q�5-      ��5,      �� *
Username+ �� UpdateSourceTrigger$ PropertyChanged=�5-      5.      � 50   
   $��2��51      $��0 10 0 0q�52       53      �� 54      $
��auto �55      �� 56      $
��auto �57       � ColumnDefinitions 59      �� 5:      $
��auto �5;       z� SharedSizeGroup$ FirstColumn��5<      �� 5=      $
��auto �5>      $ SecondColumn��5?      .+�5B      �� $��0��5C      $��0��5D      $��	Floor No.��5E      �� 5F      $��1��5G      $��0��5H      $��0 5 0 0q�5J      ��5I      �� *FloorNumber+$ PropertyChanged=�5J      �� 5L      $��0��5M      $��1��5N      $��10 0 0 0q�5O      $��Room No.��5P      �� 5Q      $��1��5R      $��1��5S      $��10 5 0 0q�5U      ��5T      �� *
RoomNumber+$ PropertyChanged=�5U      5V      � 5X   
   $��3��5Y      $��0 10 0 0q�5Z       5[      �� 5\      $
��auto �5]      �� 5^      $
��auto �5_       5a      �� 5b      $
��auto �5c      $ FirstColumn��5d      �� 5e      $
��auto �5f      $ SecondColumn��5g      .+�5j      �� $��0��5k      $��0��5l      $��
Start Date��5m      (  "System.Windows.Controls.DatePicker  5n      $��1��5o      $��0��5p      $��0 5 0 0q�5q         SelectedDate 5r      �� *	StartDate+$ PropertyChanged=��� 5t      $��0��5u      $��1��5v      $��10 0 0 0q�5w      $��End Date��5x        5y      $��1��5z      $��1��5{      $��10 5 0 0q�5|       5}      �� *	EndDate+$ PropertyChanged=�5~      �� 5�   
   $��4��5�       �� Orientation$ 
Horizontal=�5�      $��0 10 0 0q�5�      .+�5�      �� $��Submit��5�      ��5�      �� *SubmitCommand+5�      �� 5�      $��10 0 0 0q�5�      $��Cancel��5�      ��5�      �� *CancelCommand+5�      5�      5�      5�      