   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  5      %clr-namespace:mobileAir	mobileAir  5      !    mobileAir.pages.NewRegister   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5      9mobileAir.NewRegisterclr-namespace:mobileAir     5        N� Title$  NewRegister��5
      .��5      �� $��New User��6   $��10q�6!   $��14(�6-   $��Arial)�6;   .��5   
   �� $	��0.5q�6   
�������$	��350��6:   $	��618��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63      Opacity$	 100Q�6C      ShadowDepth$ 0Q�6Q      	Direction$ 0Q�6a   ._�5      �� $��Center=�6   $��Center=�66   .+�5      � $	��500��6    � RowDefinitions 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � ColumnDefinitions 5      �� 5      �� 5      .+�5!      �� -   5        $��txtname��5!   `   $��0��6   $��0��6+   $��1��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6o   $��Center=�6�   $
��Left=�6�   .��6�   ��5"      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5#   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   	 �� 
TargetType"	 ��6W   
 �� 	Resources
 5$   "      CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5%   &   $
 Left=�6I   $
 None=�6[    5&   *   �� 5'   .   $��	Full Name��64   
�������$��10q�6Z   5)   '   5*   #    �� Triggers 5+   "   P� 5,   &    P� Property � �� �� Empty P� Value# Z 6>   . �5-   *   ��  �� Property � �� �� Value# [  6H   5.   '   P� 5/   &    � �� 6>   Z� . �50   *   ��  � ��# [  6G   51   '   P� 52   &    �@J�IsKeyboardFocused . . �53   *   ��  � ��
 �����6G   54   '   56      .��57   )   58      (  "System.Windows.Controls.DatePicker  5:      -   5        $��txtbirthdate��5:   c   $��0��6!   $��1��6.   $��2��6>   $��35��6K   $	��245��6W   $��0,0,0,10q�6w   $��Center=�6�   $��Right=�6�    � 	Resources 5;      :  4System.Windows.Controls.Primitives.DatePickerTextBox��%[   '        �� 5<      "	  6$   .�5=   "   ��  �@��
IsReadOnly . 6?   5>      5?      5@      �� 5B      -   5        $��	cbbgender��5B   a   $��1��6   $��0��6,   $��3��6<   $��35��6I   $	��245��6U   $��0,0,0,10q�6r   $��Center=�6�   $
��Left=�6�   @�5C      �� 5D      $
��MALE��6+    �� 
IsSelected . 6:   �� 5E      $��FEMALE��6+   5G      �� 5I      -   5        $��txtphone��5I   `   $��1��6   $��1��6+   $��4��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6p   $��Center=�6�   $��Right=�6�   .��6�   ��5J      1&clr-namespace:System;assembly=mscorlibSystem 5K   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   "	 ��6W   
 5L   "   ��%�   &	        !� 5M   &   $
 Left=�6I   $
 None=�6[    5N   *   �� 5O   .   $��Phone��64   
�������$��10q�6V   5Q   '   5R   #    5S   "   P� 5T   &    � ��# Z 6>   . �5U   *   ��  � ��# [  6H   5V   '   P� 5W   &    � �� 6>   Z� . �5X   *   ��  � ��# [  6G   5Y   '   P� 5Z   &    �@J�IsKeyboardFocused . . �5[   *   ��  � ��
 �����6G   5\   '   5^      .��5_   )   5`      �� 5b      -   5        $��txtemail��5b   `   $��2��6   $��0��6+   $��5��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6p   $��Center=�6�   $
��Left=�6�   .��6�   ��5c      1&clr-namespace:System;assembly=mscorlibSystem 5d   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   "	 ��6W   
 5e   "   ��%�   &	        !� 5f   &   $
 Left=�6I   $
 None=�6[    5g   *   �� 5h   .   $��Email��64   
�������$��10q�6V   5j   '   5k   #    5l   "   P� 5m   &    � ��# Z 6>   . �5n   *   ��  � ��# [  6H   5o   '   P� 5p   &    � �� 6>   Z� . �5q   *   ��  � ��# [  6G   5r   '   P� 5s   &    �@J�IsKeyboardFocused . . �5t   *   ��  � ��
 �����6G   5u   '   5w      .��5x   )   5y      �� 5{      -   5        $��txtuname��5{   `   $��2��6   $��1��6+   $��6��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6p   $��Center=�6�   $��Right=�6�   .��6�   ��5|      1&clr-namespace:System;assembly=mscorlibSystem 5}   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   "	 ��6W   
 5~   "   ��%�   &	        !� 5   &   $
 Left=�6I   $
 None=�6[    5�   *   �� 5�   .   $��Username��64   
�������$��10q�6Y   5�   '   5�   #    5�   "   P� 5�   &    � ��# Z 6>   . �5�   *   ��  � ��# [  6H   5�   '   P� 5�   &    � �� 6>   Z� . �5�   *   ��  � ��# [  6G   5�   '   P� 5�   &    �@J�IsKeyboardFocused . . �5�   *   ��  � ��
 �����6G   5�   '   5�      .��5�   )   5�      G� 5�      -   5        $��txtpass��5�   L   $��3��6"   $��0��6/   $��7��6?   $��35��6[   $	��245��6g   $��0,0,0,10q�6s   $��Center=�6�   $
��Left=�6�   ��5�      �� 5�      "	 G�6$   .�5�   "   �� "  mobileAir.PasswordBoxMonitor �@ IsMonitoring . 6j   �� 5�   "    � �� 5�   &   �� 5�   *    �� 
TargetType" G�6:   .R�5�   .   �� $��Bd��65   #��z��6?   #��z��6i   #��z��6�    J� SnapsToDevicePixels . ._�5�   2   � .+�5�   6   ��  ��Name$ PART_ContentHost��6C   # z 6]   �� 5�   6   $��	txtPrompt��6�   $��Password��6@   $��Center=�6P   $��10,0,0,0q�6k   $��12(�6}   
�������$y�	Collapsed=�6�   6�   5�   3   5�   /    �� Triggers 5�   .   P� 5�   2    � {� .  . �5�   6   ��  �� 
TargetName$ Bd��6=   # � ��6c    � ���� 5�   6   # � ��6S    � ��5�   3   P� 5�   2    �@ PasswordLength$ 0��6}   . �5�   6   �� $ 	txtPrompt��6S    � y�$ Visible=�6j   5�   3   5�   +   5�   #   5�      5�      G� 5�      -   5        $��txtcpass��5�   L   $��3��6"   $��1��6/   $��8��6?   $��35��6\   $	��245��6h   $��0,0,0,10q�6t   $��Center=�6�   $��Right=�6�   ��5�      �� 5�      "	 G�6$   .�5�   "   ��  �@ IsMonitoring . 6j   �� 5�   "    � �� 5�   &   �� 5�   *   " G�6:   .R�5�   .   �� $��Bd��65   #��z��6?   #��z��6i   #��z��6�    . ._�5�   2   � .+�5�   6   �� $ PART_ContentHost��6C   # z 6]   �� 5�   6   $��	txtPrompt��6�   $��Confirm Password��6@   $��Center=�6X   $��10,0,0,0q�6s   $��12(�6�   
�������$y�	Collapsed=�6�   6�   5�   3   5�   /    5�   .   P� 5�   2    � {� .  . �5�   6   �� $ Bd��6=   # � ��6c    � ���� 5�   6   # � ��6S    � ��5�   3   P� 5�   2    �@ PasswordLength$ 0��6}   . �5�   6   �� $ 	txtPrompt��6S    � y�$ Visible=�6j   5�   3   5�   +   5�   #   5�      5�      �� 5�      -	   5        $��cbbsecurity��5�   �   $��4��6   $��0��6,   $��35��6<   $��9��6H   $	��245��6U    �� SelectedValuePath$	 Tag��6a   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6y   $��0,0,0,10q�6�   $��Center=�6�   $
��Left=�6�   �� 5�      -
   5        $��
txtansware��5�   a   $��4��6   $��1��6+   $��35��6;   $��10��6G   $	��245��6U   $��0,0,0,10q�6s   $��Center=�6�   $��Right=�6�   .��6�   ��5�      1&clr-namespace:System;assembly=mscorlibSystem 5�   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   "	 ��6W   
 5�   "   ��%�   &	        !� 5�   &   $
 Left=�6I   $
 None=�6[    5�   *   �� 5�   .   $��Answare��64   
�������$��10q�6X   5�   '   5�   #    5�   "   P� 5�   &    � ��# Z 6>   . �5�   *   ��  � ��# [  6H   5�   '   P� 5�   &    � �� 6>   Z� . �5�   *   ��  � ��# [  6G   5�   '   P� 5�   &    �@J�IsKeyboardFocused . . �5�   *   ��  � ��
 �����6G   5�   '   5�      .��5�   )   5�      �� 5�      -   5        $��
btnsubmint��5�   �   $��5��6   $��0��6*   $��11��6:   $��35��6H   $	��245��6T   $��Submit��6`   $
��Left=�6r    � Cursor$
 Hand��6�   6�   �� 5�      -   5        $��btnreset��5�   �   $��5��6   $��1��6*   $��12��6:   $��35��6H   $	��245��6T   $��Reset��6`   $��Right=�6p   $
 Hand��6�   6�   �� 5�      -   5        $��lblerror��5�   =   $��6��6   $��2��6)   $��35��6M   $	��500��6Y   $��	10,0,0,10q�6e   $��Center=�6x   $��Center=�6�   
���  ��6�   5�      5�      5�      5�      5�      