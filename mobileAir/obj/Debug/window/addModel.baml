   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:mobileAir.windowmobileAir.window  5   	       mobileAir.window.addModel   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:mobileAir.window     5   	     � Title$  	Add Model��5   	   $	��170��6   $	��370��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o    � AllowsTransparency . ���#1e90ff.��5   
   �� $	��0.5q�6   
�������$	��150��6:   $	��350��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63      Opacity$	 100Q�6C   	   ShadowDepth$	 0Q�6Q   
   	Direction$
 0Q�6a   ._�5      �� $��Center=�6   $��Center=�66   .+�5      �� -   5        $��txtname��5   2   $��35��6   $	��300��6&   $��0,0,0,10q�6A   $��Center=�6S    �� CharacterCasing$ Upper=�6u   .��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6     �� 
TargetType" ��6S    �� 	Resources 5         CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5   "   $
 Left=�6E   $
 None=�6W    5   &   �� 5   *   $��Model��60   
�������$��10q�6R   5   #   5       �� Triggers 5      P� 5   "    P� Property � �� �� Empty P� Value# Z 6:   . �5   &   ��  �� Property � �� �� Value# [  6D   5   #   P� 5   "    � �� 6:   Z� . �5   &   ��  � ��# [  6C   5    #   P� 5!   "    �@J�IsKeyboardFocused . . �5"   &   ��  � ��
 �����6C   5#   #   5%      .��5&   %   5'      � 5)      $	��300��6    � RowDefinitions 5*      �� 5+       � ColumnDefinitions 5-      �� 5.      �� 5/      .+�51      �� -   5        $��
btnsubmint��51   �   $��1��6   $��0��6*   $��35��6:   $	��145��6F   $��	Add Model��6R   $
��Left=�6g    � Cursor$
 Hand��6�   6�   �� 52      -   5        $��btnclose��52   �   $��1��6   $��1��6*   $��35��6:   $	��145��6F   $��Close��6R   $��Right=�6b   $
 Hand��6~   6�   53      54      55      57      