   M S B A M L   `   `   `  ����D  @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages  5      #    mobileAir.pages.VehicleReport   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5        N� Title$  VehicleReport��5	       � 	Resources 5       #  Body_Content_DataGrid_Centering �� 
TargetType*  $System.Windows.Controls.DataGridCell �� Property �� Value �� 
TargetType��%�   &	        �� 5   
   "  68   .�5      ��  � �� 5      �� 5      "  6&   .R�5      � #��z��6   .+�5      �� $��Center=�6/   $��2,5,2,5q�6J   5      5      5      5      5      .��5      �� $��Vehicle Report��6   $��10q�6'   $��14(�63   $��Arial)�6A   .��5   
   �� $	��0.5q�6   
�������$	��550��6:   $
��1200��6G   
������� J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         
BlurRadius$ 10Q�6#      Color$ #cccccc��63   	   Opacity$		 100Q�6C   
   ShadowDepth$
 0Q�6Q      	Direction$ 0Q�6a   ._�5      �  � RowDefinitions 5      �� 5       $��45 �6$   �� 5!       � ColumnDefinitions 5#      �� 5$      �� 5%      �� 5&      �� 5'      �� 5(      .+�5*      �� -   5        $��
txtvehicle��5*   S   $��0��6   $��5��6'   $��30��6;   $	��245��6G   $��10,0,0,0q�6e   $��Center=�6w   $
��Left=�6�    �� CharacterCasing$ Upper=�6�   .��6�   ��5+      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5,       �� 6   6sys&clr-namespace:System;assembly=mscorlib     6    " ��6S    �� 	Resources 5-        CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	       !� 5.   "   $
 Left=�6E   $
 None=�6W    5/   &   �� 50   *   $��
Vehicle No��60   
�������$��10q�6W   52   #   53       �� Triggers 54      P� 55   "    P� Property � �� �� Empty P� Value# Z 6:   . �56   &   ��  � ��# [ 6D   57   #   P� 58   "    � �� 6:   Z� . �59   &   ��  � ��# [ 6C   5:   #   P� 5;   "    �@J�IsKeyboardFocused . . �5<   &   ��  � ��
 �����6C   5=   #   5?      .��5@   %   5A      �� 5B      -   5        $��btnview��5B   I   $��0��6   $��5��6&   $
��View��6:   $��0,3,0,3q�6X   $��0,0,10,0q�6j   $��30��6|   $��50��6�   $��Center=�6�   $��Right=�6�    � Cursor$
 Hand��6�   &   System.Windows.Controls.DataGrid  5C      -   5        $��dgvehicleno��5C   �      	CellStyle# [  6   $��1��6X   $��5��6e      AutoGenerateColumns .     
IsReadOnly . "   VerticalScrollBarVisibility$ Visible=�6�      Columns 5D      0  *System.Windows.Controls.DataGridTextColumn  5E      ,  &System.Windows.Controls.DataGridColumn   Header$ Serv_id��6-      
Visibility$ Hidden=�6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   �� *	serv_id+6Z     5F      $ 
Vehicle No��6-       Width5  /System.Windows.Controls.DataGridLengthConverter$	  150 6A    6M   �� *	vehicleno+  5G      $ Customer Name��6-   $  * 6D    6N   �� *
customer+  5H      $ Bill No��6-   $	  150 6>    6J   �� *billno+  5I      $ 	Bill Date��6-   $	  150 6@    6L   �� *
billdate+  5J      $ Km��6-   $	  150 69    6E   �� *km+  5K      $ Grand Total��6-   $	  150 6B    6N   �� *
grandtotal+5M      5N      5O      5P      5Q      