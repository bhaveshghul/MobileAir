   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  #    mobileAir.pages.ManageService   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  ManageService��.���� $��Manage Service��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��550��$
��1200��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��   Opacity$	 100Q�   ShadowDepth$ 0Q�   	Direction$ 0Q�._��  � RowDefinitions �� $��45 ���  � ColumnDefinitions �� .+��� -   $��btnnewrecord��$��0��$��2��$��Add Service��$��35��$	��150��$��5q�	 � Cursor$
	 Hand��$��Right=�&   System.Windows.Controls.DataGrid  -   $��	dgservice��$��1��$��2��
   AutoGenerateColumns
 .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Bill No��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *billno+  $ Customer Name��$ *  �� *
customer+  $ 	Bill Date��$	 150  �� *
billdate+  $ 
Vehical No��$	 150  �� *	vehicleno+  $ Model��$	 150  �� *model+  $ 
GrandTotal��$	 150  �� *
grandtotal+4  .System.Windows.Controls.DataGridTemplateColumn  $	 110    HeaderTemplate �� .R��� $��Action��   CellTemplate �� .R���  �� Orientation$ 
Horizontal=�.+��� $��btnedit��-   $
��Edit��$��0,3,0,3q�$��	0,0,2.5,0q�$��51������ *	serv_id+�� $��	btndelete��-   $��Delete��$��0,3,0,3q�$��	2.5,0,0,0q�$��51������ *	serv_id+