   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:mobileAir.mastermobileAir.master      mobileAir.master.Home   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:mobileAir.master       � Title$
  Home��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=� � WindowState$ 	Maximized=� � 	Resources    btv  	VsMenuTop �� 
TargetType m� IsSubmenuOpen � AllowsTransparency K� IsItemsHost �� 
TargetType	 �� Triggers
 P� Property P� Value �� Property �� Value  	VsMenuSub ]�Name �� RelativeSource �� 	Converter �� Triggers �� 
TargetName  	VsMenuSep  VsOnline �� Orientation��%2  &	        &	      &	 �     7   &	 �    &	 �    'o� �    �� �� " m�.R��� $
��15px(�$��40��.+��� #��z��$��5q�
�������� #��z  . |�.  .���� $��1q�
����������#E0E0E0._���  . ���� " ��	 P� 
 �@J�IsMouseOver . . ���  � �� �#106EBE�� " m�.R�]� $ panel��$
��15px(�.+��� $��20��$	��5,0q����� *Icon+ �� *TemplatedParent+�� #��z��
���   �$��0,5,5,5q��� $��../image/icon_right.png��y��� *
HasItems+8    �� *TemplatedParent+� #��z  . |�.  $��Right=�.���� $��1q�
����������#E0E0E0._���  .  P� 
 �@m�IsHighlighted . . ��� $ panel�� � �� �#EFF6FC�� " ��.R��� $��1�����#E0E0E0�� " m�.R��� $
��15px(�$��40��$ 
Horizontal=����#005A9E.+��� #��z��$��5q�
��������� $��../image/icon_down.png��$��20��$��0,0,5,0q�� #��z  . |�.  .���� $��1q�
����������#E0E0E0._���  . �� " o�.���  � �� �#0078D7��  � ��$
 40px�� J� CommandBindings )  #System.Windows.Input.CommandBinding  -      Command$! NavigationCommands.GoToPage��.���� $ Vertical=�$��Stretch=�$��Stretch=�.+��  � RowDefinitions �� ��  � ColumnDefinitions �� .+�o�  o� 
IsMainMenu . $��0��$��0��.@�m� $��
_MobileAir��#��[ .@�m� $��_User��#��[  m� Icon$  ../image/icon_backlogs.png�� m� Command$! NavigationCommands.GoToPage�� m� CommandParameter$" ../pages/ManageRegister.xaml�� m� CommandTarget ��  �� ElementName$ 
frmContent��m� -   $��_Logout��#��[ $  ../image/icon_backlogs.png��m� $��_NewBill��#��[ $! NavigationCommands.GoToPage��$ ../pages/NewService.xaml�� �� $ 
frmContent��m� $��_ManageBill��#��[ $! NavigationCommands.GoToPage��$! ../pages/ManageService.xaml�� �� $ 
frmContent��m� $��_Reports��#��[ .@�m� $��_CustomerReport��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$" ../pages/CustomerReport.xaml�� �� $ 
frmContent��m� $��_VehicleReport��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$! ../pages/VehicleReport.xaml�� �� $ 
frmContent��m� $��_YearlyReport��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$  ../pages/YearlyReport.xaml�� �� $ 
frmContent��m� $��_PaymentReport��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$! ../pages/PaymentReport.xaml�� �� $ 
frmContent��m� $��_Master��#��[ .@�m� $��	_Customer��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$" ../pages/ManageCustomer.xaml�� �� $ 
frmContent��m� $��_Model��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$ ../pages/ManageModel.xaml�� �� $ 
frmContent��m� $��_Technician��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$$ ../pages/ManageTechnician.xaml�� �� $ 
frmContent��m� $��_Payment��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$! ../pages/ManagePayment.xaml�� �� $ 
frmContent��m� $��_Labour��#��[ $  ../image/icon_backlogs.png��$! NavigationCommands.GoToPage��$  ../pages/ManageLabour.xaml�� �� $ 
frmContent�� � -   $��
frmContent��$��1��$��0��  � NavigationUIVisibility$ 	Automatic=�  � Source$ ../pages/Default.xaml?�$	��665��$��Bottom=�