   M S B A M L   `   `   `  ����J  FPracrica_Atelie, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:Pracrica_AteliePracrica_Atelie  5   	       Pracrica_Atelie.Grid   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:Pracrica_Atelie     5   	     � Title$
  Grid��5   	   $	��450��6   $	��800��6#   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
dtg_orders��5
         AutoGenerateColumns .  $��	0,0,0,234q�6n      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ IdOrder��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5   "   ��  �� Path$ IdOrder�6E     5      $ TimeOfOrder��6%    5   "   �� $ TimeOfOrder�6I     5      $ EndTime��6%    5   "   �� $ EndTime�6E     5      $ 
IdEmployee��6%    5   "   �� $ 
IdEmployee�6H     5      $ IdClient��6%    5   "   �� $ IdClient�6F     5      $ IdTitleWork��6%    5   "   �� $ IdTitleWork�6I     5      $ IdMaterials��6%    5   "   �� $ IdMaterials�6I   5      �� 5   
   -   5         ��Name$ btn_add��5      $��Добавить��6"   $
��Left=�65   $��136,217,0,0q�6P   $	��Top=�6e   $��55��6}   $	��111��6�   6�   �� 5   
   -   5        $ 
btn_delete��5      $��Удалить��6%   $��Center=�67   $��	0,217,0,0q�6T   $	��Top=�6g   $��55��6   $	��112��6�   6�   �� 5   
   -   5        $ btn_red��5      $��Изменить��6"   $
��Left=�65   $��556,217,0,0q�6P   $	��Top=�6e   $	��111��6}   $��55��6�   6�   5      5       