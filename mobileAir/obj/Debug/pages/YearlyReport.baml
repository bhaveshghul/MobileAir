   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  5      "    mobileAir.pages.YearlyReport   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5        N� Title$  YearlyReport��5	       � 	Resources 5       #  Body_Content_DataGrid_Centering �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType��%�   &	        �� 5   
   "  68   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��2,5,2,5q�6J   5      5      5      5      5      .��5      �� $��Yealy Report��6   $��10q�6%   $��14(�61   $��Arial)�6?   .��5   
   �� $	��0.5q�6   
�������$	��550��6:   $
��1200��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63   	   Opacity$		 100Q�6C   
   ShadowDepth$
 0Q�6Q      	Direction$ 0Q�6a   ._�5      �  � RowDefinitions 5      �� 5       $��45 �6$   �� 5!       � ColumnDefinitions 5#      �� 5$      $	��300 �6'   �� 5%      .+�5(      (  "System.Windows.Controls.DatePicker  -   5        $��txtsdate��5(      $��0��6-   $��0��6:   $��30��6J   $	��245��6V   $��10,0,0,0q�6b   $��Center=�6t   $
��Left=�6�   6�     5)      -   5        $��txtedate��5)      $��0��6-   $��1��6:   $��30��6J   $	��245��6V   $��Center=�6b   $
��Left=�6�   6�   �� 5*      -   5        $��btnview��5*   I   $��0��6   $��5��6&   $
��View��6:   $��0,3,0,3q�6X   $��0,0,10,0q�6j   $��30��6|   $��50��6�   $��Center=�6�   $��Right=�6�    � Cursor$
 Hand��6�   &   System.Windows.Controls.DataGrid  5,      -   5        $��dgyearly��5,   �      	CellStyle# [  6   $��1��6X   $��2��6e      AutoGenerateColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�6�      Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Header$ Serv_id��6-      
Visibility$ Hidden=�6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	serv_id+6Z     5/      $ Customer Name��6-      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6D    6N   �� *
customer+  50      $ Bill No��6-   $ * 6>    6H   �� *billno+  51      $ 	Bill Date��6-   $ * 6@    6J   �� *
billdate+  52      $ Model��6-   $ * 6<    6F   �� *model+  53      $ Reg. No��6-   $ * 6>    6H   �� *	vehicleno+  54      $ Amount��6-   $ * 6=    6G   �� *amount+  55      $ Outstanding��6-   $ * 6B    6L   �� *outstanding+  56      $ 
Grandtotal��6-   $ * 6A    6K   �� *
grandtotal+58      59      5:      5;      5<      