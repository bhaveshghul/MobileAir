   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages      mobileAir.pages.Payment   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  Payment��.���� $��Payment��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��258��$	��618��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��   Opacity$	 100Q�   ShadowDepth$ 0Q�   	Direction$ 0Q�._��� $��Center=�$��Center=�.+�� $	��500�� � RowDefinitions �� �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��
textpaymid��$y�Hidden=��� -   $��
textpaymno��$y�Hidden=��� -   $��
cbbpayment��$��0��$��0��$��35��$��1��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�@��� $
��CASH��	 �� 
IsSelected	 . �� $��CHEQUE��(  "System.Windows.Controls.DatePicker  -   $��
txtpaydate��$��0��$��1��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=�
 � 	Resources
 :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%6   '        �� "  .���  �@��
IsReadOnly . �� -   $��cbbcustomer��$��1��$��0��$��2�� �� SelectedValuePath$	 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=��� -   $��	cbbbillno��$��1��$��1��$��3��$	 Tag��$
 TrueY�$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=��� -   $��txtbillamount��$��2��$��0��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=� �� 
IsReadOnly . ���#E8E8E8.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� �� 	Resources    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%T   &	        !� $
 Left=�$
 None=� �� $��Bill Amount��
�������$��10q� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtoutstanding��$��2��$��1��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=� . 
�������.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%Q   &	        !� $
 Left=�$
 None=� �� $��Discount��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -	   $��	txtamount��$��3��$��0��$��4��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%O   &	        !� $
 Left=�$
 None=� �� $��Amount��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -
   $��
btnsubmint��$��4��$��0��$��5��$��35��$	��245��$��Submit��$
��Left=� � Cursor$
 Hand���� -   $��btnreset��$��4��$��1��$��6��$��35��$	��245��$��Reset��$��Right=�$
 Hand��