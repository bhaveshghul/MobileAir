   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:mobileAir.mastermobileAir.master  5   	       mobileAir.master.Home   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:mobileAir.master     5   	     � Title$
  Home��5   	   $	��450��6   $	��800��6#    � WindowStartupLocation$ CenterScreen=�6/    � WindowState$ 	Maximized=�6T    � 	Resources 5
         btv  	VsMenuTop �� 
TargetType m� IsSubmenuOpen � AllowsTransparency K� IsItemsHost �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value  	VsMenuSub ]�Name �� RelativeSource �� 	Converter �� Triggers �� 
TargetName  	VsMenuSep  VsOnline �� Orientation��%�  &	        &	      &	 �    7   &	 W    &	 �    'o� B    �� 5   
   6'   �� 5   
   " m�6,   .R�5      �� $
��15px(�6   $��40��63   .+�5      �� #��z��6   $��5q�6;   
�������6F   � 5      #��z 6    . |�.  .��5      �� $��1q�6   
����������#E0E0E0._�5      ��  . 6%   5      5      ��5      �� 5      " ��6   	 5      P� 5      
 �@J�IsMouseOver . . �5   "   ��  � �� �#106EBE6?   5      5       5"      5#      �� 5&   
   " m�6,   .R�5'      ]� $ panel��62   $
��15px(�6   .+�5)      �� $��20��6a   $	��5,0q�6l   ��6   �� *Icon+ �� *TemplatedParent+6l   �� 5*      #��z��6   
���   �$��0,5,5,5q�6N   �� 5-      $��../image/icon_right.png��6   y�69   �� *
HasItems+8    �� *TemplatedParent+� 50      #��z 6    . |�.  $��Right=�6m   .��51      �� $��1q�6   
����������#E0E0E0._�52      ��  . 6%   53      54      55       56      P� 57      
 �@m�IsHighlighted . . �58      �� $ panel��63    � �� �#EFF6FC6F   59      5;      �� 5>   
   " ��6,   .R�5?      �� $��1��6   ���#E0E0E06    5@      �� 5C   
   " m�6+   .R�5D      �� $
��15px(�6   $��40��63   $ 
Horizontal=�6?   ���#005A9E.+�5E      �� #��z��6   $��5q�6;   
�������6F   �� 5F      $��../image/icon_down.png��6   $��20��68   $��0,0,5,0q�6D   � 5I      #��z 6    . |�.  .��5J      �� $��1q�6   
����������#E0E0E0._�5K      ��  . 6%   5L      5M      5N      5O      �� 5R   
   " o�6   .�5S      ��  � �� �#0078D76+   �� 5T       � ��$
 40px��6'   5U      5V       J� CommandBindings 5X      )  #System.Windows.Input.CommandBinding  5Y   
   -   5           Command$! NavigationCommands.GoToPage��5Y      6a   .��5\      �� $ Vertical=�6   $��Stretch=�6(   $��Stretch=�6F   .+�5l   
   �  � RowDefinitions 5m      �� 5n      �� 5o       � ColumnDefinitions 5q      �� 5r      .+�5t      o�  o� 
IsMainMenu . $��0��6%   $��0��62   .@�5u      m� $��
_MobileAir��6   #��[ 6/   .@�5v      m� $��_User��6   #��[ 6.    m� Icon$  ../image/icon_backlogs.png��6T    m� Command$! NavigationCommands.GoToPage��6v    m� CommandParameter$" ../pages/ManageRegister.xaml��6�    m� CommandTarget 6�   ��  �� ElementName$ 
frmContent��m� 5w      -   5        $��_Logout��5w      #��[ 60   $  ../image/icon_backlogs.png��6V   6x   5x      m� 5y      $��_NewBill��6   #��[ 6-   $! NavigationCommands.GoToPage��6S   $ ../pages/NewService.xaml��6y    6�   �� $ 
frmContent��5z      m� 5{      $��_ManageBill��6   #��[ 60   $! NavigationCommands.GoToPage��6V   $! ../pages/ManageService.xaml��6|    6�   �� $ 
frmContent��5|      m� 5}      $��_Reports��6   #��[ 6-   .@�5~      m� $��_CustomerReport��6   #��[ 68   $  ../image/icon_backlogs.png��6^   $! NavigationCommands.GoToPage��6�   $" ../pages/CustomerReport.xaml��6�    6�   �� $ 
frmContent��m� 5      $��_VehicleReport��6   #��[ 67   $  ../image/icon_backlogs.png��6]   $! NavigationCommands.GoToPage��6   $! ../pages/VehicleReport.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_YearlyReport��6   #��[ 66   $  ../image/icon_backlogs.png��6\   $! NavigationCommands.GoToPage��6~   $  ../pages/YearlyReport.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_BillReport��6   #��[ 64   $  ../image/icon_backlogs.png��6Z   $! NavigationCommands.GoToPage��6|   $ ../pages/BillReport.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_PaymentReport��6   #��[ 67   $  ../image/icon_backlogs.png��6]   $! NavigationCommands.GoToPage��6   $! ../pages/PaymentReport.xaml��6�    6�   �� $ 
frmContent��5�      m� 5�      $��_Master��6   #��[ 6,   .@�5�      m� $��	_Customer��6   #��[ 62   $  ../image/icon_backlogs.png��6X   $! NavigationCommands.GoToPage��6z   $" ../pages/ManageCustomer.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_Model��6   #��[ 6/   $  ../image/icon_backlogs.png��6U   $! NavigationCommands.GoToPage��6w   $ ../pages/ManageModel.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_Technician��6   #��[ 64   $  ../image/icon_backlogs.png��6Z   $! NavigationCommands.GoToPage��6|   $$ ../pages/ManageTechnician.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_Payment��6   #��[ 61   $  ../image/icon_backlogs.png��6W   $! NavigationCommands.GoToPage��6y   $! ../pages/ManagePayment.xaml��6�    6�   �� $ 
frmContent��m� 5�      $��_Labour��6   #��[ 60   $  ../image/icon_backlogs.png��6V   $! NavigationCommands.GoToPage��6x   $  ../pages/ManageLabour.xaml��6�    6�   �� $ 
frmContent��5�      5�       � 5�      -   5        $��
frmContent��5�   T   $��1��6   $��0��6!     � NavigationUIVisibility$ 	Automatic=�61     � Source$ ../pages/Default.xaml?�6f   $	��665��6�   $��Bottom=�6�   5�      5�      5�      