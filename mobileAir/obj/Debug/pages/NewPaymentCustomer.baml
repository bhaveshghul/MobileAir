   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  5      (    "mobileAir.pages.NewPaymentCustomer   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5        N� Title$  Payment��5	      .��5      �� $��Payment��6   $��10q�6    $��14(�6,   $��Arial)�6:   .��5   
   �� $	��0.5q�6   
�������$	��258��6:   $	��618��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63      Opacity$	 100Q�6C      ShadowDepth$ 0Q�6Q      	Direction$ 0Q�6a   ._�5      �� $��Center=�6   $��Center=�66   .+�5      � $	��500��6    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5        $��
textpaymid��5       $y�Hidden=�62   �� 5      -   5        $��
textpaymno��5       $y�Hidden=�62   �� 5!      -   5        $��
cbbpayment��5!   a   $��0��6   $��0��6,   $��35��6<   $��1��6H   $	��245��6U   $��0,0,0,10q�6s   $��Center=�6�   $
��Left=�6�   @�5"      �� 5#      $
��CASH��6+   	 �� 
IsSelected	 . 6:   �� 5$      $��CHEQUE��6+   �� 5%      $
��BANK��6+   5'      (  "System.Windows.Controls.DatePicker  5)      -   5        $��
txtpaydate��5)   V   $��0��6!   $��1��6.   $��35��6>   $	��245��6J   $��0,0,0,10q�6h   $��Center=�6z   $��Right=�6�   
 � 	Resources
 5*      :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%[   '        �� 5+      "  6$   .�5,   "   ��  �@��
IsReadOnly . 6?   5-      5.      5/      �� 51      -   5        $��cbbcustomer��51   �   $��1��6   $��0��6,   $��2��6<    �� SelectedValuePath$	 Tag��6I   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6a   $��35��6�   $	��245��6�   $��0,0,0,10q�6�   $��Center=�6�   $
��Left=�6�   6   �� 52      -   5        $��txtoutstanding��52   S   $��1��6   $��1��6+   $��35��6;   $	��245��6G   $��0,0,0,10q�6i   $��Center=�6{   $��Right=�6�    �� 
IsReadOnly . 
�������.��6�   ��53      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 54   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   " ��6W    �� 	Resources 55   "      CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 56   &   $
 Left=�6I   $
 None=�6[    57   *   �� 58   .   $��Discount��64   
�������$��10q�6Y   5:   '   5;   #    �� Triggers 5<   "   P� 5=   &    P� Property � �� �� Empty P� Value# Z 6>   . �5>   *   ��  � ��# [  6H   5?   '   P� 5@   &    � �� 6>   Z� . �5A   *   ��  � ��# [  6G   5B   '   P� 5C   &    �@J�IsKeyboardFocused . . �5D   *   ��  � ��
 �����6G   5E   '   5G      .��5H   )   5I      �� 5K      -   5        $��	txtamount��5K   `   $��3��6   $��0��6+   $��4��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6q   $��Center=�6�   $
��Left=�6�   .��6�   ��5L      1&clr-namespace:System;assembly=mscorlibSystem 5M   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   " ��6W    5N   "   ��%�   &	        !� 5O   &   $
 Left=�6I   $
 None=�6[    5P   *   �� 5Q   .   $��Amount��64   
�������$��10q�6W   5S   '   5T   #    5U   "   P� 5V   &    � ��# Z 6>   . �5W   *   ��  � ��# [  6H   5X   '   P� 5Y   &    � �� 6>   Z� . �5Z   *   ��  � ��# [  6G   5[   '   P� 5\   &    �@J�IsKeyboardFocused . . �5]   *   ��  � ��
 �����6G   5^   '   5`      .��5a   )   5b      �� 5d      -   5        $��
btnsubmint��5d   �   $��4��6   $��0��6*   $��5��6:   $��35��6G   $	��245��6S   $��Submit��6_   $
��Left=�6q    � Cursor$
 Hand��6�   6�   �� 5e      -	   5        $��btnreset��5e   �   $��4��6   $��1��6*   $��6��6:   $��35��6G   $	��245��6S   $��Reset��6_   $��Right=�6o   $
 Hand��6�   6�   5f      5g      5h      5i      5j      