   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.PagesmobileAir.Pages  5      !    mobileAir.Pages.NewCustomer   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.Pages     5        N� Title$  NewCustomer��5	      .��5      �� $��New Customer��6   $��10q�6%   $��14(�61   $��Arial)�6?   .��5   
   �� $	��0.5q�6   
�������$	��258��6:   $	��618��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63      Opacity$	 100Q�6C      ShadowDepth$ 0Q�6Q      	Direction$ 0Q�6a   ._�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5        $��txtname��5   ?   $��35��6   $��1��6&   $	��500��63   $��0,0,0,10q�6N   $��Center=�6`    �� CharacterCasing$ Upper=�6�   .��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6     �� 
TargetType" ��6S   	 �� 	Resources	 5         CueBannerBrush
 j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5   "   $

 Left=�6E   $
 None=�6W    5   &   �� 5   *   $��CustomerName��60   
�������$��10q�6Y   5   #   5       �� Triggers 5      P� 5   "    P� Property � �� �� Empty P� Value# Z 6:   . �5   &   ��  �� Property � �� �� Value# [  6D   5   #   P� 5   "    � �� 6:   Z� . �5    &   ��  � ��# [  6C   5!   #   P� 5"   "    �@J�IsKeyboardFocused . . �5#   &   ��  � ��
 �����6C   5$   #   5&      .��5'   %   5(      �� 5)      -   5        $��
txtaddress��5)   ?   $��35��6   $��2��6&   $	��500��63   $��0,0,0,10q�6Q   $��Center=�6c    �� TextWrapping$
 Wrap=�6�    �� AcceptsReturn . $ �� HorizontalScrollBarVisibility$ Disabled=�6�   " �� VerticalScrollBarVisibility$
 Auto=�6�   $ Upper=�6�   .��6  ��5*      1&clr-namespace:System;assembly=mscorlibSystem 5+       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6    " ��6S   	 5,      ��%�   &	        !� 5-   "   $

 Left=�6E   $
 None=�6W    5.   &   �� 5/   *   $��Address��60   
�������$��10q�6T   51   #   52       53      P� 54   "    � ��# Z 6:   . �55   &   ��  � ��# [  6D   56   #   P� 57   "    � �� 6:   Z� . �58   &   ��  � ��# [  6C   59   #   P� 5:   "    �@J�IsKeyboardFocused . . �5;   &   ��  � ��
 �����6C   5<   #   5>      .��5?   %   5@      � 5A      $	��500��6    � RowDefinitions 5B      �� 5C      �� 5D       � ColumnDefinitions 5F      �� 5G      �� 5H      .+�5J      �� -   5        $��txtphone��5J   `   $��0��6   $��0��6+   $��3��6;   $��35��6H   $	��245��6T   $��0,0,0,10q�6p   $��Center=�6�   $
��Left=�6�   $ Upper=�6�   .��6�   ��5K      1&clr-namespace:System;assembly=mscorlibSystem 5L   $   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6$   " ��6W   	 5M   "   ��%�   &	        !� 5N   &   $

 Left=�6I   $
 None=�6[    5O   *   �� 5P   .   $��Phone��64   
�������$��10q�6V   5R   '   5S   #    5T   "   P� 5U   &    � ��# Z 6>   . �5V   *   ��  � ��# [  6H   5W   '   P� 5X   &    � �� 6>   Z� . �5Y   *   ��  � ��# [  6G   5Z   '   P� 5[   &    �@J�IsKeyboardFocused . . �5\   *   ��  � ��
 �����6G   5]   '   5_      .��5`   )   5a      �� 5b      -   5        $��cbbcustomertype��5b   �   $��0��6   $��1��6,   $��4��6<   $��35��6I   $	��245��6U    �� SelectedValuePath$	 Tag��6a   $ �� IsSynchronizedWithCurrentItem$
 TrueY�6y   $��0,0,0,10q�6�   $��Center=�6�   $��Right=�6�   @�5c      �� 5d      $��DI��6+   
 � Tag$ DI��68   �� 5e      $��IN��6+   $ IN��68   5g      �� 5h      -   5        $��
btnsubmint��5h   �   $��1��6   $��0��6*   $��6��6:   $��35��6G   $	��245��6S   $��Submit��6_   $
��Left=�6q    � Cursor$
 Hand��6�   6�   �� 5i      -   5        $��btnreset��5i   �   $��1��6   $��1��6*   $��7��6:   $��35��6G   $	��245��6S   $��Reset��6_   $��Right=�6o   $
 Hand��6�   6�   5j      5k      5l      5m      5n      