   M S B A M L   `   `   `  ����@  <02.11, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:_02._11_02._11  5   	       _02._11.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:_02._11     5   	     � Title$  
MainWindow��5   	   $	��422��6   $	��670��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��285* �6   �� 5      $	��89* �6   .+�5   
   �� -   5         ��Name$ search��5      $��
Поиск��6!   $
��Left=�61   $��	42,46,0,0q�6L   $	��Top=�6_   6w   �� 5   
   -   5         ��Name$ 
list_price��5      $��192,44,192,226q�6Q   �� 5   
   -   5         ��Name$ list_component��5      $
��Left=�6+   $��
349,46,0,0q�6F   $	��Top=�6Z   $	��120��6r   .@�5      �� $��	Processor��6   �� 5      $��graphics card��6   �� 5      $	��RAM��6   �� 5      $��	hard disk��6   �� 5      $	��ssd��6   �� 5      $��
CPU cooler��6   �� 5      $��monitor��6   �� 5      $��keyboard��6   �� 5      $
��mous��6   5      �� 5   
   -   5         ��Name$ 
full_price��5      $��full_price: 0��6$   $
��Left=�6<   $��	192,0,0,0q�6W   $��Center=�6j   �� 5   
   -   5        $ components_form��5      $��
Components��6*   $
��Left=�6?   $��255,225,0,0q�6Z   $	��Top=�6o   6�   �� 5   
   -   5        $ price_component��5      $��price:��6)   $
��Left=�6:   $��
496,46,0,0q�6U   $	��Top=�6i   $��2��6�   �� 5   
   -   5        $ add_component��5      $	��add��6(   $
��Left=�66   $��
349,83,0,0q�6Q   $	��Top=�6e   6}   5!      5"      