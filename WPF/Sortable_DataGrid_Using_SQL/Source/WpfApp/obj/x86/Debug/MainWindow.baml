   M S B A M L   `   `   `  ����
  WpfApp    WpfApp.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Simple Data Grid��5   	    � SizeToContent$ WidthAndHeight=�5   	    � 
ResizeMode$ NoResize=�5   	   .��5      �  � 	Resources 5	   
    �� MergedDictionaries �� Source�� 5
       5      �� 5      $" Themes\DataGrid.Generic.xaml?�6)   %    5       � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   o� -   5        $��menu1��5      $��27��5      $��0��6   
�������$
��Left=�5      $	��Top=�5      .@�5      m� $��_File��6   .@�5      m� -   5        $��E_xit��5      5      5      m� 5      $��_Action��6   .@�5       m� -   5        $��
_Read Data��5!      5#      5$      m� 5%      $��_Help��6   5&      5'      �� 5)   
   $��5,0,5,5q�6   $��1��6&   .+�5+      &   System.Windows.Controls.DataGrid  -   5        $��DataGridBookOrders��5+         CanUserAddRows .     AutoGenerateColumns .  	   Columns	 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn
   Header$
 Customer Name��6)      
FontWeight$
 Bold"�51   %      
Foreground
 ��  �1  +System.Windows.Controls.DataGridBoundColumn   Binding 50   %   ��  �� Path$ CustomerName�52   %     53      $
 Address��6)    54   %   �� $ Address�  55      $

 City��6)    56   %   �� $
 City�  57      $	
 Zip��6)    58   %   �� $	 Zip�  59      $
 State��6)    5:   %   �� $ State�  5;      $

 ISBN��6)    5<   %   �� $
 ISBN�  5=      $
 Title��6)    5>   %   �� $ Title�  5?      $

 Cost��6)    5@   %   �� $
 Cost�  5A      $
 Quantity��6)    5B   %   �� $ Quantity�  5C      $
 	Publisher��6)    5D   %   �� $ 	Publisher�  5E      $
 Author��6)    5F   %   �� $ Author�  5G      $
 	OrderDate��6)    5H   %   �� $ 	OrderDate� �� StringFormat$ d��5L      5N      5O      5P      