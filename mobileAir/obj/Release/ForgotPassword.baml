   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:mobileAir	mobileAir  %clr-namespace:mobileAir	mobileAir      mobileAir.ForgotPassword   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     )localclr-namespace:mobileAir     <mobileAir.ForgotPasswordclr-namespace:mobileAir       � Title$  ForgotPassword�� � WindowStartupLocation$ CenterScreen=�.���� $	��0.5q�
�������$	��410��$	��550��._��� $��Center=�$��Center=�$	��330��$	��600��.+��� -   $��txtuname��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" �� �� 	Resources    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%S   &	        !� $ Center=�$
 None=� �� $��Username��
�������$��10q� �� Triggers P�  P� Property � ��	 �� Empty
 P� Value#
 Z	 . ���  �� Property � �� �� Value# [  P�  � ��
 Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused
 . . ���  � ��
 �����.���� -   $��txtemail��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%P   &	        !� $ Center=�$
 None=� �� $��Email��
�������$��10q� P�  � ��#
 Z	 . ���  � ��# [  P�  � ��
 Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused
 . . ���  � ��
 �����.���� -   $��cbbsecurity��$��35��$	��450��$��0,0,0,10q� �� SelectedValuePath$	 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��Center=�$��Center=�$��Center=��� -   $��
txtansware��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%R   &	        !� $ Center=�$
 None=� �� $��Answare��
�������$��10q� P�  � ��#
 Z	 . ���  � ��# [  P�  � ��
 Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused
 . . ���  � ��
 �����.��G� -   $��txtpass��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=����� " G�.��� "  mobileAir.PasswordBoxMonitor �@ IsMonitoring . ��  � �� ��  �� 
TargetType" G�.R��� $��Bd��#��z��#��z��#��z�� J� SnapsToDevicePixels . ._�� .+���  ��Name$ PART_ContentHost��# z �� $��	txtPrompt��$��Password��$��Center=�$��Center=�
�������$y�	Collapsed=� �� Triggers P�  � {�
 .  . ���  �� 
TargetName$ Bd��# � �� � ���� # � �� � ��P�  �@ PasswordLength$
 0��. ��� $ 	txtPrompt�� � y�$ Visible=�G� -   $��txtcpass��$��35��$	��450��$��0,0,0,10q�$��Center=�$��Center=����� " G�.���  �@ IsMonitoring . ��  � �� �� " G�.R��� $��Bd��#��z��#��z��#��z�� . ._�� .+��� $ PART_ContentHost��# z �� $��	txtPrompt��$��Confirm Password��$��Center=�$��Center=�
�������$y�	Collapsed=� P�  � {�
 .  . ��� $ Bd��# � �� � ���� # � �� � ��P�  �@ PasswordLength$
 0��. ��� $ 	txtPrompt�� � y�$ Visible=�� $	��450�� � RowDefinitions �� $��35 � � ColumnDefinitions �� �� .+��� -    ��Name$ btnlogin��$��0��$��1��$��Submit��$��35��$	��220��$
��Left=��� -   $ btnclose��$��1��$��1��$��Close��$��35��$	��220��$��Right=��� -	   $��lblerror��$��35��$	��450��$��	10,0,10,0q�$��Center=�$��Center=�
���  ��