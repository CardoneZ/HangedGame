   M S B A M L   `   `   `  ����J  FAhorcadoCliente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:AhorcadoCliente.PagesAhorcadoCliente.Pages  5      G(clr-namespace:AhorcadoCliente.PropertiesAhorcadoCliente.Properties  5      '    !AhorcadoCliente.Pages.CreateMatch   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:AhorcadoCliente.Pages     5      6p(clr-namespace:AhorcadoCliente.Properties     5        N� Title$  CreateMatch��5
      .��5      � ���#4d9eed � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� -   5         ��Name$ cbWordCategories��5      $
��Left=�6-   $��292,185,0,0q�6H   $	��Top=�6]   $	��200��6u   6�   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6"   $��Right=�6;   $��	0,0,10,10q�6W   .+�5      �� -   5        *   $AhorcadoCliente.Properties.Resources   CancelCreateMatchButton#��Z 5      $��35��6N   $	��130��6Z   $��	Monocraft)�5      ���#D6D5A8$��14(�6A   $��Medium"�6O    � Cursor$
 Hand��6c   ���#28c4fc��5      �� 5       �� 
TargetType" ��6    �� Triggers 5      P� 5       P� Property �@J�IsMouseOver	 P� Value	 . . �5   "   �� 
 �� Property
 � �� �� Value �#1B24306?   5      5      ��5!      �� 5"       �� 
TargetType" ��6&   .R�5#      �� $	��130��6!   $��35��6-    �� CornerRadius$ 8��69   #��z��6J   ._�5$      �� $��Center=�6/   $��Center=�6J   5%      5&      5(      �� 5)      -   5         ��Name$ CreateMatchButton��5)         CreateMatchButton#��Z 60   $��35��6c   $	��130��6o   $��5q�6{   $��	Monocraft)�5*      ���#D6D5A8$��14(�6A   $��Medium"�6O   $
 Hand��6c   ���#28c4fc��5,      �� 5-      " ��6    5.      P� 5/       �@J�IsMouseOver	 . . �50   "   �� 
 � �� �#1B24306?   51      53      ��55      �� 56      " ��6&   .R�57      �� $	��130��6!   $��35��6-   $ 8��69   #��z��6J   ._�58      �� $��Center=�6/   $��Center=�6J   59      5:      5<      5=      �� 5>   
      CategoriesCreateMatch#��Z 6   $
��Left=�6G   $��292,155,0,0q�6b   $	��Top=�6w   $��	Monocraft)�6�    J� RenderTransformOrigin$ -0.111,0.52&�6�   �� 5?   
   -   5        $ cbSelectWord��5?      $
��Left=�6)   $��575,185,0,0q�6D   $	��Top=�6Y   $	��200��6q   �� 5@   
      SelectWordCreateMatch#��Z 6   $
��Left=�6G   $��575,155,0,0q�6b   $	��Top=�6w   $��	Monocraft)�6�   �� 5A   
      GameLanguageLabel#��Z 6   $
��Left=�6C   $��
270,81,0,0q�6^   $	��Top=�6r   $��	Monocraft)�6�   $	��290��6�   �� 5B   
   -   5           EnglishButton#��Z 5B      $
��Left=�6@   $��
541,80,0,0q�6[   $	��Top=�6o   $��90��6�   $��25��6�   $��	Monocraft)�5C   	   ���#D6D5A8$��14(�65   $��Medium"�6C   $
 Hand��6W   ���#28c4fc��5E      �� 5F      " ��6    5G      P� 5H       �@J�IsMouseOver	 . . �5I      �� 
 � �� �#1B24306;   5J      5L      ��5N      �� 5O      " ��6"   .R�5P      �� $��90��6   $��25��6(   $ 8��64   #��z��6E   ._�5Q      �� $��Center=�6+   $��Center=�6F   5R      5S      5U      �� 5W   
   -   5           SpanishButton#��Z 5W      $
��Left=�6@   $��
650,78,0,0q�6[   $	��Top=�6o   $��90��6�   $��25��6�   $��	Monocraft)�5X   	   ���#D6D5A8$��14(�65   $��Medium"�6C   $
 Hand��6W   ���#28c4fc��5Z      �� 5[      " ��6    5\      P� 5]       �@J�IsMouseOver	 . . �5^      �� 
 � �� �#1B24306;   5_      5a      ��5c      �� 5d      " ��6"   .R�5e      �� $��90��6   $��25��6(   $ 8��64   #��z��6E   ._�5f      �� $��Center=�6+   $��Center=�6F   5g      5h      5j      �� 5k   
   $"��/Images/skull-motorcycle.png��6   $��-28,215,502,-12q�66   $��2��6O   6b   5l      5m      