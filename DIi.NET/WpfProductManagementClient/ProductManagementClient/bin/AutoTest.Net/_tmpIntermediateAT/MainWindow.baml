   M S B A M L   `   `   `  ����  ProductManagementClient:    4Ploeh.Samples.ProductManagement.WpfClient.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Product Management��5   	   $	��300��5   	   $	��300��5   	   $	��300��5   	   $	��300��5   	    � 	Resources 5	         ProductStyle �� 
TargetType �� Property �� Value �� Path �� Mode��%{   &	        �� 5
   
   " ��6%   .�5      ��  �@��
IsSelected 6+   �� $ 
IsSelected�$ TwoWay=�5      5      .��5      ]�  +� FocusedElement 6   ��  �� ElementName$ productsListView��.+�5   
   o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      �� m� 5      $��E_xit��6   	 m� Command	 6*   �� $ CloseCommand�5      m� 5      $��_Actions��6   .@�5      m� $��_Refresh��6   
 m� InputGestureText$
 F5��6-   	 6C   �� $ RefreshCommand�m� 5      $��_Add Product��6   $	
 Ins��61   	 6H   �� $ InsertProductCommand�m� 5      $��_Edit Product��6   $
 Enter��62   	 6K   �� $ EditProductCommand�m� 5      $��_Delete Product��6   $	
 Del��64   	 6K   �� $ DeleteProductCommand�5      5      `� 5   
   $	��Top=�6   $��Stretch=�6+   .�5      c� $��Stretch=�6   $
��Left=�64   .@�5      �� ��6   �� $ RefreshCommand�.��6A   	Refresh6J   �� 5      ��6   �� $ InsertProductCommand�.��6G   Add6L   �� 5      ��6   �� $ EditProductCommand�.��6E   Edit6K   �� 5       ��6   �� $ DeleteProductCommand�.��6G   Delete6O   5!      5"      �� 5#   
   -   5         ��Name$ productsListView��5#      #��[  6-    �� SelectionMode$ Single=�6�   ��6`   �� $ Products� �� View 5$      �� 5%      .P�5&      �� $��Id��6%    �� DisplayMemberBinding 61   �� $ Id��� 5'      $
��Name��6%    63   �� $
 Name��� 5(      $��Price��6%    64   �� $ 	UnitPrice�5)      5+      5,      5-      