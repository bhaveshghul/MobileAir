   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  $    mobileAir.pages.CustomerReport   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  CustomerReport�� � 	Resources  #  Body_Content_DataGrid_Centering �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType��%d   &	        �� "  .���  � �� �� "  .R�� #��z��.+��� $��Center=�$��2,5,2,5q�.���� $��Customer Report��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��550��$
��1200��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��	   Opacity$		 100Q�
   ShadowDepth$
 0Q�   	Direction$ 0Q�._��  � RowDefinitions �� $��45 ���  � ColumnDefinitions �� �� �� �� �� .+�� $��0��$��5�� ��  �� $	��300 ��� $	��300 ��� $	��300 ��� $	��300 �.+��� -   $��cbbcustomer��$��0��$��0�� �� SelectedValuePath$	 Tag��$ �� IsSynchronizedWithCurrentItem$
 TrueY�$��30��$	��245��$��Center=�$��10,0,0,0q�$
��Left=��� -   $��cbbmonth��$y�Hidden=�$��0��$��0��$	 Tag��$
 TrueY�$��30��$	��245��$��0,0,70,0q�$��Center=�$��Right=� �� SelectedIndex$ 0��.@��� $��--Select Month--��
 � Tag$ 0���� $��January��$ 1���� $��February��$ 2���� $��March��$ 3���� $��April��$ 4���� $	��May��$ 5���� $
��June��$ 6���� $
��July��$ 7���� $��August��$ 8���� $��	September��$ 9���� $��October��$ 10���� $��November��$ 11���� $��December��$ 12��(  "System.Windows.Controls.DatePicker  -   $��txtsdate��$��0��$��1��$��30��$	��245��$��Center=�$
��Left=�  -   $��txtedate��$��0��$��2��$��30��$	��245��$��Center=�$
��Left=��� $��0��$��4��$��30��$	��150��$
��Left=�$��Center=�����  �� ElementName$ 
dgcustomer�� �� Path$ SelectedItem.serv_id� �� UpdateSourceTrigger$ Explicit=��� -   $��btnview��$��0��$��4��$
��View��$��0,3,0,3q�$��0,0,10,0q�$��30��$��50��$��Center=�$��Right=� � Cursor$
 Hand��&   System.Windows.Controls.DataGrid  -   $��
dgcustomer��   	CellStyle# [  $��1��$��5��   AutoGenerateColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Serv_id��   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	serv_id+  $ Bill No��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *  �� *billno+  $ 	Bill Date��$ *  �� *
billdate+  $ 
Vehicle No��$ *  �� *	vehicleno+  $ Model��$ *  �� *model+  $ Grand Total��$ *  �� *
grandtotal+  $ Pending Amt��$ *  �� *
pendingamt+  $ Padi Amt��$ *  �� *	paidamt+