   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.PagesmobileAir.Pages  !    mobileAir.Pages.NewCustomer   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.Pages       N� Title$  NewCustomer��.���� $��New Customer��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��258��$	��618��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��   Opacity$	 100Q�   ShadowDepth$ 0Q�   	Direction$ 0Q�._��� $��Center=�$��Center=�.+��� -   $��txtname��$��35��$��1��$	��500��$��0,0,0,10q�$��Center=� �� CharacterCasing$ Upper=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib      �� 
TargetType" ��	 �� 	Resources	    CueBannerBrush
 j� 
AlignmentX j� Stretch !� Visual��%U   &	        !� $

 Left=�$
 None=� �� $��CustomerName��
�������$��10q� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  �� Property � �� �� Value# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��
txtaddress��$��35��$��2��$	��500��$��0,0,0,10q�$��Center=� �� TextWrapping$
 Wrap=� �� AcceptsReturn . $ �� HorizontalScrollBarVisibility$ Disabled=�" �� VerticalScrollBarVisibility$
 Auto=�$ Upper=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " ��	 ��%P   &	        !� $

 Left=�$
 None=� �� $��Address��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.��� $	��500�� � RowDefinitions �� ��  � ColumnDefinitions �� �� .+��� -   $��txtphone��$��0��$��0��$��3��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�$ Upper=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " ��	 ��%N   &	        !� $

 Left=�$
 None=� �� $��Phone��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��cbbcustomertype��$��0��$��1��$��4��$��35��$	��245�� �� SelectedValuePath$	 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��0,0,0,10q�$��Center=�$��Right=�@��� $��DI��
 � Tag$ DI���� $��IN��$ IN���� -   $��
btnsubmint��$��1��$��0��$��6��$��35��$	��245��$��Submit��$
��Left=� � Cursor$
 Hand���� -   $��btnreset��$��1��$��1��$��7��$��35��$	��245��$��Reset��$��Right=�$
 Hand��