   M S B A M L   `   `   `  ���� h  dSAPBusinessObjects.WPF.Viewer, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304tRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.ViewerSAPBusinessObjects.WPF.Viewer  D @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages "   mobileAir.pages.BillnoReport   ]ViewerRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.Viewer  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  BillnoReport��.���  � RowDefinitions �� $��35 ���  � ColumnDefinitions �� $	��255 ��� .+��� -   $��	txtbillno��$��0��$��0��$��30��$	��245��$��10,0,0,0q�$��Center=�$
��Left=� �� CharacterCasing$ Upper=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" �� �� 	Resources    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%P   &	        !� $
 Left=�$
 None=� �� $��Bill No��
�������$��10q�	 �� Triggers	 P� 
 P� Property
 � �� �� Empty P� Value# Z . ���  �� Property � �� �� Value# [  P� 
 � �� Z� . ���  � ��# [  P� 
 �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��btnview��$��0��$��1��$
��View��$��0,3,0,3q�$��	10,0,10,0q�$��30��$��50��$
��Left=�$��Center=� � Cursor$
 Hand��8   2SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer  -     Name$ cryBillnoReport��$��1��$��5��