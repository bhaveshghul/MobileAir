   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:mobileAir	mobileAir  %clr-namespace:mobileAir	mobileAir      mobileAir.MainWindow   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:mobileAir     8mobileAir.MainWindowclr-namespace:mobileAir       � Title$  
MainWindow��$	��450��$	��800�� � WindowStartupLocation$ CenterScreen=�.���� $	��0.5q�
�������$	��250��$	��550��._��� $��Center=�$��Center=�$	��170��$	��600��.+��� -   $��txtuname��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" �� �� 	Resources    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%S   &	        !� $ Center=�$
 None=� �� $��Username��
�������$��10q� �� Triggers P�  P� Property � ��	 �� Empty
 P� Value#
 Z	 . ���  �� Property � �� �� Value# [  P�  � ��
 Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused
 . . ���  � ��
 �����.��G� -   $��txtpass��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=����� " G�.��� "  mobileAir.PasswordBoxMonitor �@ IsMonitoring . ��  � �� ��  �� 
TargetType" G�.R��� $��Bd��#��z��#��z��#��z�� J� SnapsToDevicePixels . ._�� .+���  ��Name$ PART_ContentHost��# z �� $��	txtPrompt��$��Password��$��Center=�$��Center=�
�������$y�	Collapsed=� �� Triggers P�  � {�
 .  . ���  �� 
TargetName$ Bd��# � �� � ���� # � �� � ��P�  �@ PasswordLength$
 0��. ��� $ 	txtPrompt�� � y�$ Visible=�� $	��450�� � RowDefinitions �� $��35 ��� $��35 � � ColumnDefinitions �� �� .+��� $��0��$��0��$��35��$	��225��$y�Hidden=�$��Remember Me��$��Light"��� $��1��$��0��$��35��$	��225�� �� TextAlignment$ Right=��� -    �Name$ hlinkforgot��.�Forgot Password�� -    ��Name$ btnlogin��$��0��$��1��$��Login��$��35��$	��220��$
��Left=��� -   $ btnclose��$��1��$��1��$��Close��$��35��$	��220��$��Right=�