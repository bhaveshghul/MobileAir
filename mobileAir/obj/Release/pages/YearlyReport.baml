   M S B A M L   `   `   `  ���� D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  "    mobileAir.pages.YearlyReport   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     /localclr-namespace:mobileAir.pages       N� Title$  YearlyReport�� � 	Resources  #  Body_Content_DataGrid_Centering �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType��%d   &	        �� "  .���  � �� �� "  .R�� #��z��.+��� $��Center=�$��2,5,2,5q�.���� $��Yealy Report��$��10q�$��14(�$��Arial)�.���� $	��0.5q�
�������$	��550��$
��1200��
������� J� Effect 3  -System.Windows.Media.Effects.DropShadowEffect     
BlurRadius$ 10Q�   Color$ #cccccc��	   Opacity$		 100Q�
   ShadowDepth$
 0Q�   	Direction$ 0Q�._��  � RowDefinitions �� $��45 ���  � ColumnDefinitions �� $	��300 ��� .+�(  "System.Windows.Controls.DatePicker  -   $��txtsdate��$��0��$��0��$��30��$	��245��$��10,0,0,0q�$��Center=�$
��Left=�  -   $��txtedate��$��0��$��1��$��30��$	��245��$��Center=�$
��Left=��� -   $��btnview��$��0��$��5��$
��View��$��0,3,0,3q�$��0,0,10,0q�$��30��$��50��$��Center=�$��Right=� � Cursor$
 Hand��&   System.Windows.Controls.DataGrid  -   $��dgyearly��   	CellStyle# [  $��1��$��2��   AutoGenerateColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Serv_id��   
Visibility$ Hidden=�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	serv_id+  $ Customer Name��   Width5  /System.Windows.Controls.DataGridLengthConverter$ *  �� *
customer+  $ Bill No��$ *  �� *billno+  $ 	Bill Date��$ *  �� *
billdate+  $ Model��$ *  �� *model+  $ Reg. No��$ *  �� *	vehicleno+  $ Amount��$ *  �� *amount+  $ Outstanding��$ *  �� *outstanding+  $ 
Grandtotal��$ *  �� *
grandtotal+