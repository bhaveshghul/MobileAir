   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:mobileAir.windowmobileAir.window  5   	        mobileAir.window.addLabour   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:mobileAir.window     5   	     � Title$  	addLabour��5   	   $	��170��6   $	��370��6(    � WindowStartupLocation$ CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o    � AllowsTransparency . ���#1e90ff.��5	      �� $	��0.5q�6   
�������$	��150��66   $	��350��6C   
������� J� Effect 5
   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6      Color$ #cccccc��6/      Opacity$	 100Q�6?   	   ShadowDepth$	 0Q�6M   
   	Direction$
 0Q�6]   ._�5   
   �� $��Center=�6   $��Center=�62   .+�5      �� -   5        $��txtname��5   .   $��35��6   $	��300��6"   $��0,0,0,10q�6=   $��Center=�6O    �� CharacterCasing$ Upper=�6q   .��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �� 6   6sys&clr-namespace:System;assembly=mscorlib     6    �� 
TargetType" ��6O    �� 	Resources 5         CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5      $
 Left=�6A   $
 None=�6S    5   "   �� 5   &   $��Labour��6,   
�������$��10q�6O   5      5       �� Triggers 5      P� 5       P� Property � �� �� Empty P� Value# Z 66   . �5   "   ��  �� Property � �� �� Value# [  6@   5      P� 5       � �� 66   Z� . �5   "   ��  � ��# [  6?   5      P� 5       �@J�IsKeyboardFocused . . �5    "   ��  � ��
 �����6?   5!      5#      .��5$   !   5%      � 5'      $	��300��6    � RowDefinitions 5(      �� 5)       � ColumnDefinitions 5+      �� 5,      �� 5-      .+�5/      �� -   5        $��
btnsubmint��5/   �   $��1��6   $��0��6&   $��35��66   $	��145��6B   $��
Add Labour��6N   $
��Left=�6d    � Cursor$
 Hand��6   6�   �� 50      -   5        $��btnclose��50   �   $��1��6   $��1��6&   $��35��66   $	��145��6B   $��Close��6N   $��Right=�6^   $
 Hand��6z   6�   51      52      53      54      