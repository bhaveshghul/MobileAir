   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  %clr-namespace:mobileAir	mobileAir  !    mobileAir.pages.NewRegister   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages     9mobileAir.NewRegisterclr-namespace:mobileAir       N� Title$  NewRegister��.���� $��New User��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��350��$	��618��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��   Opacity$	 100Q�   ShadowDepth$ 0Q�   	Direction$ 0Q�._��� $��Center=�$��Center=�.+�� $	��500�� � RowDefinitions �� �� �� �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��txtname��$��0��$��0��$��1��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     	 �� 
TargetType"	 ��
 �� 	Resources
    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%R   &	        !� $
 Left=�$
 None=� �� $��	Full Name��
�������$��10q� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  �� Property � �� �� Value# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.��(  "System.Windows.Controls.DatePicker  -   $��txtbirthdate��$��0��$��1��$��2��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=� � 	Resources :  4System.Windows.Controls.Primitives.DatePickerTextBox��%6   '        �� "	  .���  �@��
IsReadOnly . �� -   $��	cbbgender��$��1��$��0��$��3��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�@��� $
��MALE�� �� 
IsSelected . �� $��FEMALE���� -   $��txtphone��$��1��$��1��$��4��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     "	 ��
 ��%N   &	        !� $
 Left=�$
 None=� �� $��Phone��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtemail��$��2��$��0��$��5��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     "	 ��
 ��%N   &	        !� $
 Left=�$
 None=� �� $��Email��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtuname��$��2��$��1��$��6��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     "	 ��
 ��%Q   &	        !� $
 Left=�$
 None=� �� $��Username��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.��G� -   $��txtpass��$��3��$��0��$��7��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=����� "	 G�.��� "  mobileAir.PasswordBoxMonitor �@ IsMonitoring . ��  � �� ��  �� 
TargetType" G�.R��� $��Bd��#��z��#��z��#��z�� J� SnapsToDevicePixels . ._�� .+���  ��Name$ PART_ContentHost��# z �� $��	txtPrompt��$��Password��$��Center=�$��10,0,0,0q�$��12(�
�������$y�	Collapsed=� �� Triggers P�  � {� .  . ���  �� 
TargetName$ Bd��# � �� � ���� # � �� � ��P�  �@ PasswordLength$ 0��. ��� $ 	txtPrompt�� � y�$ Visible=�G� -   $��txtcpass��$��3��$��1��$��8��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=����� "	 G�.���  �@ IsMonitoring . ��  � �� �� " G�.R��� $��Bd��#��z��#��z��#��z�� . ._�� .+��� $ PART_ContentHost��# z �� $��	txtPrompt��$��Confirm Password��$��Center=�$��10,0,0,0q�$��12(�
�������$y�	Collapsed=� P�  � {� .  . ��� $ Bd��# � �� � ���� # � �� � ��P�  �@ PasswordLength$ 0��. ��� $ 	txtPrompt�� � y�$ Visible=��� -	   $��cbbsecurity��$��4��$��0��$��35��$��9��$	��245�� �� SelectedValuePath$	 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��0,0,0,10q�$��Center=�$
��Left=��� -
   $��
txtansware��$��4��$��1��$��35��$��10��$	��245��$��0,0,0,10q�$��Center=�$��Right=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     "	 ��
 ��%P   &	        !� $
 Left=�$
 None=� �� $��Answare��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��
btnsubmint��$��5��$��0��$��11��$��35��$	��245��$��Submit��$
��Left=� � Cursor$
 Hand���� -   $��btnreset��$��5��$��1��$��12��$��35��$	��245��$��Reset��$��Right=�$
 Hand���� -   $��lblerror��$��6��$��2��$��35��$	��500��$��	10,0,0,10q�$��Center=�$��Center=�
���  ��