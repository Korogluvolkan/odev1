   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5   	       WpfApp1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp1     5   	     � Title$  
MainWindow��5   	   $	��650��6   $
��1200��6)    � 
ResizeMode$ NoResize=�66   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��4* �6   �� 5      $
��556* �6   �� 5      $	��50* �6   �� 5      $
��183* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ DataGridXMAL��5      $
��Left=�6*   $	��599��6E   $��
196,10,0,0q�6R   $	��Top=�6f   $	��980��6~    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��3��6�   $��1��6�   $y�Hidden=�6�    � 	Resources 5      =  7System.Windows.Controls.Primitives.DataGridColumnHeader �� 
TargetType �� Property �� Value��%�   '        �� 5      "  6   .�5      ��  � ��
 ��� �63   �� 5       � ��$ Normal"�63   �� 5       � ��$ 19(�61   �� 5       � ��$ 1,2,1,2q�68   �� 5       � ��
 �   �64   5      5      	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$
  Ogrenci ID��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 196 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	studentID+6X     5      $	
  Ad��6%   $	 196 6R    62   �� *studentName+6R     5      $
  Soyad��6%   $	 196 6X    65   �� *studentSurname+6X     5      $

  Yas��6%   $	 196 6R    63   �� *
studentAge+6R     5       $
  Bölüm��6%   $	 196 6[    65   �� *studentDepartment+6[   5#      �� 5$   
   -   5         ��Name$ ShowBTN��5$      $��Tabloyu Yenile��6"   $��1��6;   $
��Left=�6K   $��	24,51,0,0q�6f   $	��Top=�6y   $	��150��6�   $��75��6�   $��18(�6�   $y�Hidden=�6�   �� 5%   
   -   5        $ EkleBTN��5%      $��Tabloya Veri Ekle��6"   $��1��6>   $
��Left=�6N   $��
24,171,0,0q�6i   $	��Top=�6}   $	��150��6�   $��76��6�   $��18(�6�   $y�Hidden=�6�   �� 5&   
   -   5         ��Name$ 	ComboBox1��5&      $��1��6&   $
��Left=�66   $��
24,267,0,0q�6Q   $	��Top=�6e   $	��150��6}   $��20(�6�   $��46��6�   $y�Hidden=�6�   �� 5'   
   -   5        $ KisiBilgiBTN��5'      $��Kişisel Bilgiler��6'   $��1��6B   $
��Left=�6R   $��58��6m   $��	24,15,0,0q�6y   $	��Top=�6�   $	��150��6�   $��18(�6�   6�   �� 5(   
   -   5        $ TListBTN��5(      $��Tabloyu Listele��6#   $��1��6=   $
��Left=�6M   $��58��6h   $��	24,93,0,0q�6t   $	��Top=�6�   $	��150��6�   $��18(�6�   6�   � 5)   
   -   5         �Name$ PersonaLInfGrid��5)      $��3��6(   $��1��6<   $
��Left=�6L   $	��599��6g   $��
196,15,0,0q�6t   $	��Top=�6�   $	��980��6�   .+�5*      �� $�� ��6   $
��Left=�6   $	��980��6:   $	��Top=�6G   $	��326��6_   $ 0.5,0.5&�6k   $��331,-339,0,-42q�6�   z�5+      V� 5,      .~�5-      �� �� 5.      �� 5/       �� Angle$	 -90Q�6*   T� 50      51      ��53      �� 54       �� EndPoint$ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;    �� 
StartPoint$ 0.5,0&�6_   .��55      �  � Color$ 	#FFB04800��6'    � Offset$ 1Q�69   � 56      $ 	#FF320000��6'   57      59      �� 5;      $
��Left=�6   $	��222��6/   $��
85,157,0,0q�6<   $	��Top=�6P   $	��222��6h   $��Images/profilefoto.jpg��6t   $��Uniform=�6�   �� 5<      $��Volkan Köroğlu��6   $
��Left=�6-   $��47��6H   $��
46,399,0,0q�6T   $	��Top=�6h   $	��186��6�   $��24(�6�   �� 5=      $L��FArel Üniversitesi - Bilgi İşlem Daire Başkanlığı - Teknik Uzman��6   $
��Left=�6^   $��47��6y   $��
42,446,0,0q�6�   $	��Top=�6�   $	��687��6�   $��20(�6�   
����������	#FF7C7C7C6�   �� 5>      $��36 Yaşında / Evli��6   $
��Left=�60   $��47��6K   $��
42,491,0,0q�6W   $	��Top=�6k   $	��519��6�   $��20(�6�   
����������	#FF7C7C7C6�   5@      5C      5D      