   M S B A M L   `   `   `  ����K  GMantenedoresCRUD, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:MantenedoresCRUD.vistaMantenedoresCRUD.vista  5   	   1    +MantenedoresCRUD.vista.Modulo_Administrador   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:MantenedoresCRUD.vista     5   	     � Title$  Modulo_Administrador��5   	   $��700         ��6&   $
��1000��5	      
������  � WindowStartupLocation$ CenterScreen=�61    � 
ResizeMode$ NoResize=�6V    � WindowStyle$
 None=�6l    � AllowsTransparency .  � Icon$ ../skyicon.ico��6�   .��5
      � -   5        ���	#FF517E9C � ColumnDefinitions 5   
   �� 5       � RowDefinitions 5   
   �� 5      $	��65* �6   �� 5      $	��69* �6   �� 5      $
��466* �6   .+�5   
   �� ���	#FFF5F5FF$
��Left=�6%   $	��626��6@   $��	10,64,0,0q�6M   
�������$	��Top=�6o   $	��980��6�   $��3��6�   �� 5   
   -   5         ��Name$ buttonCerrar��5      $��X��6'   $
��Left=�63   $��
946,14,0,0q�6N   $	��Top=�6b   $��44��6z   $��41��6�   ���	#FF294A61$
��Bold"�6�   
���������6�   Z� �� 5   
   -   5        	 ��Name$	 image��5      $
��Left=�6   $��71��6:   $��	26,10,0,0q�6F   $��1��6Y   $	��Top=�6f   $	��172��6~   $��Resources/sky logo.png��6�   $��2��6�   �� 5   
   -   5        
 ��Name$
 labelSaludo��5      $��HOLA ADMINISTRADOR��6%   $
��Left=�6B   $��198,28.167,0,0q�6]   $��1��6u   $	��Top=�6�   $	��385��6�   $
��Thin"�6�   $��16(�6�   �� 5   
   -   5        $
 label1��5      $��MODULO ADMINISTRADOR��6    $
��Left=�6?   $��	10,14,0,0q�6Z   $	��Top=�6m   $��16(�6�   $��Medium"�6�   
�������6�   �� 5   
   -   5        $ buttonLogout��5      $��LOGOUT��6'   $
��Left=�68   $��924,10.167,0,0q�6S   $��1��6k   $	��Top=�6x   $��53��6�   $��31��6�   ��6�   Z� 6�   �� 5   
   -   5         ��Name$ groupBox��5      $��	Funciones��6%   $
��Left=�68   $��	26,10,0,0q�6S   $��2��6f   $	��Top=�6s   $	��131��6�   $	��315��6�   �� 5   
   -   5        $ 	groupBox3��5      $��Datos��6&   $
��Left=�65   $��
26,141,0,0q�6P   $��2��6d   $	��Top=�6q   $	��382��6�   $	��951��6�   �� 5   
   -	   5        $ button��5      $��-��6!   $
��Left=�6-   $��
902,14,0,0q�6H   $	��Top=�6\   $��40��6t   ���	#FF294A61$
��Bold"�6�   
�������$��41��6�   |�.  ��6�   Z� 6�   5      5      