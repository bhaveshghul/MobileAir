   M S B A M L   `   `   `  ����h  dSAPBusinessObjects.WPF.Viewer, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304tRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.ViewerSAPBusinessObjects.WPF.Viewer  5      D @mobileAir, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:mobileAir.pagesmobileAir.pages 5      "   mobileAir.pages.BillnoReport   5      ]ViewerRclr-namespace:SAPBusinessObjects.WPF.Viewer;assembly=SAPBusinessObjects.WPF.Viewer  W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35n jSAPBusinessObjects.WPF.ViewerShared, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:mobileAir.pages     5        N� Title$  BillnoReport��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��35 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $	��255 �6   �� 5      .+�5   
   �� -   5        $��	txtbillno��5   G   $��0��6   $��0��6   $��30��6/   $	��245��6;   $��10,0,0,0q�6X   $��Center=�6j   $
��Left=�6�    �� CharacterCasing$ Upper=�6�   .��6�   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      �� 6   6sys&clr-namespace:System;assembly=mscorlib     6    �� 
TargetType" ��6K    �� 	Resources 5         CueBannerBrush j� 
AlignmentX j� Stretch !� Visual��%�   &	        !� 5      $
 Left=�6=   $
 None=�6O    5      �� 5   "   $��Bill No��6(   
�������$��10q�6L   5      5      	 �� Triggers	 5      P� 5      
 P� Property
 � �� �� Empty P� Value# Z 62   . �5       ��  �� Property � �� �� Value# [  6<   5!      P� 5"      
 � �� 62   Z� . �5#      ��  � ��# [  6;   5$      P� 5%      
 �@J�IsKeyboardFocused . . �5&      ��  � ��
 �����6;   5'      5)      .��5*      5+      �� 5,   
   -   5        $��btnview��5,   =   $��0��6   $��1��6   $
��View��6.   $��0,3,0,3q�6L   $��	10,0,10,0q�6^   $��30��6q   $��50��6}   $
��Left=�6�   $��Center=�6�    � Cursor$
 Hand��6�   8   2SAPBusinessObjects.WPF.Viewer.CrystalReportsViewer  5-   
   -   5          Name$ cryBillnoReport��5-   G   $��1��6&   $��5��63   6G   5.      5/      