   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   0    *MantenedoresCRUD.vista.Ingrear_vuelo_avion   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Ingrear_vuelo_avion��5   	   $��700.5��6&   $	��758��65   
������  � WindowStartupLocation$ CenterScreen=�6Z    � 
ResizeMode$ NoResize=�6    � WindowStyle$
 None=�6�    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5	      � -   5        ���	#FF1F4F6E � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��69* �6   �� 5      $
��466* �6   .+�5   
   �� ���	#FFF5F5FF$	��643��6%   $��	10,45,0,0q�62   
�������$	��Top=�6T   $��3��6l   $
��Left=�6}   $	��740��6�   �� 5   
   -   5         ��Name$ image��5      $
��Left=�6   $��71��6:   $��10,0,0,0q�6F   $��1��6X   $	��Top=�6e   $	��172��6}   $��Resources/sky logo.png��6�   $��2��6�   �� 5   
   -   5        	 ��Name$	 label1��5      $��Ingresar Vuelo��6    $
��Left=�69   $��	10,14,0,0q�6T   $	��Top=�6g   $��16(�6   $��Medium"�6�   
�������$��31��6�   $	��115��6�   �� 5   
   -   5        
 ��Name$
 buttonCancel��5      $��Cancelar��6'   $
��Left=�6:   $��678,0.167,0,0q�6U   $��1��6l   $	��Top=�6y   $��53��6�   $��32��6�   ��6�   Z� 6�   �� 5   
   -   5        $	 label��5      $!��PASO 2, SELECCIONE AERONAVE��6   $
��Left=�6E   $��160,53.167,0,0q�6`   $��1��6x   $	��Top=�6�   $��26��6�   $	��220��6�   �� 5   
   -   5        $	 labelHorasDespegue��5      $
��Left=�6-   $��370,142,0,0q�6H   $��2��6]   $	��Top=�6j   $��Medium"�6�   ���	#FF7D84CB6�   �� 5   
   -   5        $	 labelHoraArribo��5      $
��Left=�6*   $��370,209,0,0q�6E   $��2��6Z   $	��Top=�6g   $��Medium"�6   ���	#FF7D84CB6�   �� 5   
   -   5         ��Name$ groupBox��5      $��Busqueda��6%   $
��Left=�67   $��36,3.667,0,0q�6R   $��2��6h   $	��Top=�6u   $��98��6�   $	��262��6�   �� 5   
   -	   5         ��Name$ comboBoxTipoAeronave��5      $
��Left=�61   $��62,24.667,0,0q�6L   $��2��6c   $	��Top=�6p   $	��120��6�   6�   �� 5   
   -
   5         ��Name$ textBoxMatricula��5      $
��Left=�6,   $��23��6G   $��62,66.667,0,0q�6S   $��2��6j    �� TextWrapping$
 Wrap=�6w   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -   5        $
 buttonBuscar��5      $��Buscar��6'   $
��Left=�68   $��206,41.667,0,0q�6S   $��2��6k   $	��Top=�6x   $��76��6�   6�   �� 5   
   -   5        $ 	groupBox1��5      $��Seleccionar Aeronave��6&   $
��Left=�6D   $��36,101.667,0,0q�6_   $��2��6w   $	��Top=�6�   $	��419��6�   $	��695��6�   .��5      �� -   5         ��Name$ listViewAeronave��5      $
��Left=�61   $	��126��6L   $��
314,10,0,0q�6Y   $	��Top=�6m   $	��328��6�    �� View 5      �� 5       .P�5!      �� 5"      5$      5%      &   System.Windows.Controls.DataGrid  5&   
   -   5          Name$ dataGridListaNave��5&      $
��Left=�6.   $��45,123.667,0,0q�6I   $��2��6a   $	��Top=�6n   $	��388��6�   $	��281��6�   ���	#FFA5CBCF���	#FF101F64   RowBackground �	#FFD6ECF0   
IsReadOnly . 6�     5'   
   -   5        $ dataGrid��5'      $
��Left=�6%   $��356,275.667,0,0q�6@   $��2��6Y   $	��Top=�6f   $	��184��6~   $	��302��6�    J� RenderTransformOrigin$ 0.487,0.476&�6�    .    Columns 5(      4  .System.Windows.Controls.DataGridTemplateColumn  5)         CellTemplate 5*      �� 5+      .R�5,   "   �� -   5        
���   �|�.  ��5,   <   Z� .��6w   Seleccionar6�   5-      5/      51      �� 52   
   -   5        $	 labelPrueba��52      $��Label��6%   $
��Left=�65   $��418,44.167,0,0q�6P   $��1��6h   $	��Top=�6u   53      54      