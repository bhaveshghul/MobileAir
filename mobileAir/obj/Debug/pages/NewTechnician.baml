   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  5      #    mobileAir.pages.NewTechnician   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5        N� Title$  NewTechnician��5	      .��5      �� $��New Technician��6   $��10q�6'   $��14(�63   $��Arial)�6A   .��5   
   �� $	��0.5q�6   
�������$	��258��6:   $	��618��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63      Opacity$	 100Q�6C      ShadowDepth$ 0Q�6Q      	Direction$ 0Q�6a   ._�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5        $��txtname��5   ?   $��35��6   $	��500��6&   $��1��62   $��0,0,0,10q�6N   $��Center=�6`    �� CharacterCasing$ Upper=�6�   .��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6     �� 
TargetType" ��6S   	 �� 	Resources	 5         CueBannerBrush
 j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5   "   $

 Left=�6E   $
 None=�6W    5   &   �� 5   *   $��
Technician��60   
�������$��10q�6W   5   #   5       �� Triggers 5      P� 5   "    P� Property � �� �� Empty P� Value# Z 6:   . �5   &   ��  �� Property � �� �� Value# [  6D   5   #   P� 5   "    � �� 6:   Z� . �5    &   ��  � ��# [  6C   5!   #   P� 5"   "    �@J�IsKeyboardFocused . . �5#   &   ��  � ��
 �����6C   5$   #   5&      .��5'   %   5(      � 5*      $	��500��6    � RowDefinitions 5+      �� 5,       � ColumnDefinitions 5.      �� 5/      �� 50      .+�52      �� -   5        $��
btnsubmint��52   �   $��1��6   $��0��6*   $��2��6:   $��35��6G   $	��245��6S   $��Submit��6_   $
��Left=�6q    � Cursor$
 Hand��6�   6�   �� 53      -   5        $��btnreset��53   �   $��1��6   $��1��6*   $��3��6:   $��35��6G   $	��245��6S   $��Reset��6_   $��Right=�6o   $
 Hand��6�   6�   54      55      56      57      58      