   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages       mobileAir.pages.NewService   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  
NewService��.���� $��New Service��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��550��$	��618��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��   Opacity$	 100Q�   ShadowDepth$ 0Q�   	Direction$ 0Q�._��� $��Center=�$��Center=�.+�� $	��500�� � RowDefinitions �� �� �� �� �� �� �� �� �� �� �� ��  � ColumnDefinitions �� �� .+��� -   $��
textservid��$y�Hidden=��� -   $��
textlaboid��$y�Hidden=��� -   $��
textlabono��$y�Hidden=��� -   $��	txtbillno��$��0��$��0��$��35�����#E8E8E8$	��245��$��0,0,0,10q�$��Center=�$
��Left=�	 �� 
IsReadOnly	 . .���� -   $��cbbcustomer��$��0��$��1��$��1��
 �� SelectedValuePath$	
 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=��� -   $��cbbmodel��$��1��$��0��$��2��$	
 Tag��$
 TrueY�$��35��$	��200��$��0,0,0,10q�$��Center=�$
��Left=��� -   $��btnaddmodel��$��1��$��0��$��35��$��40��$	�� + �� � Cursor$
 Hand��$��0,0,5,10q�$��Center=�$��Right=�(  "System.Windows.Controls.DatePicker  -   $��txtdate��$��1��$��1��$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=� � 	Resources :  4System.Windows.Controls.Primitives.DatePickerTextBox �� 
TargetType �� Property �� Value��%6   '        �� "  .���  �@��
IsReadOnly . �� -	   $��txtvehicalno��$��2��$��0��$��3��$��35��$	��245�� �� CharacterCasing$ Upper=�$��0,0,0,10q�$��Center=�$
��Left=�.����O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� �� 	Resources    CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%S   &	        !� $
 Left=�$
 None=� �� $��
Vehicle No��
�������$��10q� �� Triggers P�  P� Property � �� �� Empty P� Value# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -
   $��cbbtechnician��$��2��$��1��$��4��$	
 Tag��$
 TrueY�$��35��$	��245��$��0,0,0,10q�$��Center=�$��Right=��� -   $��txtkm��$��3��$��0��$��5��$��35��$	��245��$��0,0,0,10q�$��Center=�$
��Left=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%K   &	        !� $
 Left=�$
 None=� �� $��Km��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��btngetmodel��$��3��$��1��$��35��$	��100��$�� + Model��$��5,0,0,10q�$
 Wait��$��Center=�$��Center=�$
��Left=��� -   $��btngetlabour��$��3��$��1��$��35��$	��100��$��	 + Labour��$��0,0,0,10q�$
 Wait��$��Center=�$��Center=�$��Right=��� $��4��$��2��$��Stretch=�
�������$��1��$��0,0,0,10q��� -   $��txtlabodeteid��$��0��$��0��$��35��$	��122��$
��Left=�$��Center=�$y�Hidden=�����  �� ElementName$ dglabour�� �� Path$ SelectedItem.labodete_id� �� UpdateSourceTrigger$ Explicit=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%X   &	        !� $
 Left=�$
 None=� �� $��Labo Details Id��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��	cbblabour��$��5��$��0��$��6��$	
 Tag��$
 TrueY�$��35��$	��200��$��0,0,0,10q�$��Center=�$
��Left=� �� SelectedValue �� $ dglabour��$ SelectedValue.labo_id�$ Explicit=��� -   $��btnaddlabour��$��5��$��0��$��35��$��40��$	�� + ��$
 Hand��$��0,0,5,10q�$��Center=�$��Right=�� $��5��$��1��$��0,0,0,10q� ��  �� �� .+��� -   $��txtlabouramount��$��0��$��0��$��7��$��35��$	��122��$
��Left=�$��Center=����� $ dglabour��$ SelectedItem.amount�$ Explicit=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%O   &	        !� $
 Left=�$
 None=� �� $��Amount��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��btnadd��$��0��$��1��$��8��$��35��$��61��$	��Add��$
��Left=�$
 Hand���� -   $��	btndelete��$��0��$��1��$��9��$��35��$��61��$��Delete��$��Right=�$
 Hand��&   System.Windows.Controls.DataGrid  -   $��dglabour��$��6��$��2��$��90��$	��500��$��0,0,0,10q�   AutoGenerateColumns .    CanUserAddRows .      
IsReadOnly  . "!   VerticalScrollBarVisibility$! Visible=��� -   $��btngettotal��$��7��$��2��$��10��$��35��$	��500��$��0,0,0,10q�$��	GET TOTAL��$
 Hand��� $��8��$��2��$��0,0,0,10q� ��  �� �� �� .+��� -   $��txttotal��$��0��$��0��$��35��$	��160��$��Center=�$��0,0,5,0q�	 . ���#E8E8E8.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%N   &	        !� $
 Left=�$
 None=� �� $��Total��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtdiscount��$��0��$��10��$��1��$��35��$	��160��$��Center=�$��2.5,0,2.5,0q�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%Q   &	        !� $
 Left=�$
 None=� �� $��Discount��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtgrandtotal��$��0��$��2��$��35��$	��160��$��Center=�$��5,0,0,0q�	 . ���#E8E8E8.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%T   &	        !� $
 Left=�$
 None=� �� $��Grand Total��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� -   $��txtnotes��$��9��$��2��$��-��$��11��$ Upper=�$��35��$	��500��$��0,0,0,10q�$��Center=�" �� TextWrapping$
" Wrap=�# �� AcceptsReturn# . $$ �� HorizontalScrollBarVisibility$$ Disabled=�"% �� VerticalScrollBarVisibility$
% Auto=�.����1&clr-namespace:System;assembly=mscorlibSystem �� 6sys&clr-namespace:System;assembly=mscorlib     " �� ��%N   &	        !� $
 Left=�$
 None=� �� $��Notes��
�������$��10q� P�  � ��# Z . ���  � ��# [  P�  � �� Z� . ���  � ��# [  P�  �@J�IsKeyboardFocused . . ���  � ��
 �����.���� $��10��$��2��$��Stretch=�
�������$��1��$��0,0,0,10q��� -   $��
btnsubmint��$��11��$��0��$��12��$��35��$	��245��$��Submit��$
��Left=�$
 Hand���� -   $��btnreset��$��11��$��1��$��13��$��35��$	��245��$��Reset��$��Right=�$
 Hand��