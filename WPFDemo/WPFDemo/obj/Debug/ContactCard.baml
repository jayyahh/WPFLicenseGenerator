   M S B A M L   `   `   `  ����B  >WPFDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WPFDemoWPFDemo  5   	       WPFDemo.ContactCard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WPFDemo     5   	   $��18(�5      $��Segoe UI)�6(     � Title$  My Driver's License��5   	   $	��300��6%   $	��500��62   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6    � RowDefinitions 5   
   �� 5      $��10 �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $��10 �6   .+�5   
   �� -   5         ��Name$ licenseTitle��5      $��1��6*   $��1��67   $��4��6G   $��Center=�6[   $��Driver's License��6x   $
��Bold"�6�   $��35(�6�   $��Italic$�6�   $��	0,10,0,20q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5       V� 5!      .~�5"      ��  �� ScaleX$	 1.5Q�6%   �� 5#      �� 5$      T� 5%      5&      5(      �� 5)   
   -   5         ��Name$ 
profilePic��5)      $��2��6$   $��1��61   $��5��6A   $	��140��6R   $��30,5,0,0q�6b   $&�� E:\WPF\WPFDemo\images\galPic.jpg��6t   �� 5*   
   -   5        $ fullName��5*      $��2��6&   $��2��63   $��Chris Hemsworth��6C   $��20,0,0,0q�6Z   �� 5+   
   -   5        $ gender��5+      $��3��6$   $��2��61   $
��Male��6A   $��20,0,0,0q�6M   �� 5,   
   -   5        $ 	birthdate��5,      $��4��6'   $��2��64   $��
1998.04.24��6D   $��20,0,0,0q�6V   �� 5-   
   -   5        $ favoriteFoods��5-      $��5��6+   $��2��68   $ ��Favorite foods: everything��6H   $
��20,0q�6j   5/      50      