   M S B A M L   `   `   `  ����C  ?Arcomage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ArcomageArcomage  5   	       Arcomage.HerniObrazovka   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Arcomage     5   	     � Title$  Arcomage��5   	   $	��900��6   $
��1600��6'   $	��900��64   $
��1600��6D   
���   � � WindowStartupLocation$ CenterScreen=�6g    � Icon$ Pictures/arcomage.ico��6�    � 	Resources 5	         	rune_icon �� ImageSource  FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  cardButtonStyle
 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  Button.MouseOver.Border2  runeIcoStyle��%S  &	        &	 0     &	 �     &	 �     &	      &	 C    &	 d    &	 �    &	 �    &		 �    &	
 �    &	     7  7  7  7  7  7  &	 �    &	 �    7  7  7  7   7  7  7  7 	 7 
 �� 5
   
   $ Pictures/rune_ico2.png��6'   �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 	#FFDDDDDD��6;   �� 5   
   $	 	#FF707070��67   �� 5   
   $	 	#FFBEE6FD��6>   �� 5   
   $	 DarkRed��6:   �� 5   
   $	 	#FFC4E5F6��6<   �� 5   
   $	 	#FF2C628B��68   �� 5   
   $	 	#FFF4F4F4��6=   �� 5   
   $	 	#FFADB2B5��69   �� 5   
   $	 	#FF838383��6=   �� 5   
   "
 ��6(   .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5        � ��8  6,   �� 5!       � ��# � ��6+   �� 5"       � ��$ 1q�60   �� 5#       � ��$ Center=�6;   �� 5$       � ��$ Center=�69   �� 5%       � ��$ 1q�6(   �� 5&       � �� 5'      �� 5(      " ��6&   .R�5)      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5*      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5+       5,      P� 5-       �@��IsDefaulted . . �5.   "   �� $ border��6@   # � ��6T    � ��5/      P� 50       �@J�IsMouseOver . . �51   "   �� $ border��6@   8   � ��6T   52      P� 53       � �� . . �54   "   �� $ border��6?   8   � ��6S   �� 55   "   $ border��6@   8   � ��6T   56      58      5:      5;      �� 5<   
   $	 	#FF3C7FB1��6;   �� 5=   
   "
 ��6%   .�5>      ��  �@�FocusVisualStyle8   61   �� 5?       � ��8  6+   �� 5@       � ��8  6,   �� 5A       � ��# � ��6+   �� 5B       � ��$ 1q�60   �� 5C       � ��$ Center=�6;   �� 5D       � ��$ Center=�69   �� 5E       � ��$ 1q�6(   �� 5F       � �� 5G      �� 5H      " ��6&   .R�5I      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5J      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5K       5L      P� 5M       �@��IsDefaulted . . �5N   "   �� $ border��6@   # � ��6T    � ��5O      P� 5P       �@J�IsMouseOver . . �5Q   "   �� $ border��6?   8   � ��6S   5R      P� 5S       � �� . . �5T   "   �� $ border��6?   8   � ��6S   �� 5U   "   $ border��6@   8   � ��6T   5V      P� 5W       � {� .  . �5X   "   �� $ border��6?   8   � ��6S   �� 5Y   "   $ border��6@   8   � ��6T   �� 5Z   "   $ contentPresenter��6K   8   � ��6i   5[      5]      5_      5`      5a      .��5b      � -   5        $��gridMain��5b      $��20q�6   ��5c   
   �� 5d       6   �� *Backgrounds+ � RowDefinitions 5f   
   �� 5g      $��2* �6   �� 5h      $��* �6   .+�5j   
   � $��0��6    � ColumnDefinitions 5k      �� 5l      $	��250 �6#   �� 5m      $��* �6#   �� 5n      $	��250 �6#    5p      �� 5q      $��50 �6    �� 5r      $��* �6    .+�5t      �� -   5        $��textblock_jmenoHrace1��5t      $��0��65   $��0��6B    �� Padding$ 5q�6R   $��Center=�6^   $
��Left=�6y   $��30(�6�   $
��Bold"�6�   
���   �$��Book Antiqua)�6�   
��� ���$�� ��6�   �� 5u      -   5        $��textblock_jmenoHrace2��5u      $��0��65   $��2��6B   $ 5q�6R   $��Center=�6^   $��Right=�6y   $��30(�6�   $
��Bold"�6�   
���   �$��Book Antiqua)�6�   
��� ���$�� ��6�   � 5v      -   5        $��	gridHrac1��5v      $��1��6$   $��0��61    5w      �� 5x      $��* �6$   �� 5y      $��* �6$   �� 5z      $��* �6$   .+�5|      � $��0��6   
���  �� 5}      �� 5~      $��2* �6(   �� 5      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5q�6D   $��Pictures/lom.jpg��6O   �� 5�      $��0��6    $��20,10,10,10q�6-   $
��Left=�6B   $��Bottom=�6]   $��50(�6x   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Tezba+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Cihly+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��Cihly��6�   5�      � 5�      $��1��6   
����� � 5�      �� 5�      $��2* �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5q�6D   $��Pictures/magie.jpg��6O   �� 5�      $��0��6    $��20,10,10,10q�6-   $
��Left=�6B   $��Bottom=�6]   $��50(�6x   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Magie+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Drahokamy+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��	Drahokamy��6�   5�      � 5�      $��2��6   
������� 5�      �� 5�      $��2* �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5,5,0,5q�6D   $��Pictures/jeskyne.jpg��6U   $��2��6s   �� 5�      $��0��6    $��20,0,0,9q�6-   $
��Left=�6?   $��Bottom=�6Z   $��50(�6u   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Jeskyne+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Prisery+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��
Příšery��6�   $��2��6�   5�      5�      � 5�      -   5        $��	gridHrac2��5�      $��1��6$   $��2��61    5�      �� 5�      $��* �6$   �� 5�      $��* �6$   �� 5�      $��* �6$   .+�5�      � $��0��6   
���  �� 5�      �� 5�      $��2* �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5q�6D   $��Pictures/lom.jpg��6O   �� 5�      $��0��6    $��20,10,10,10q�6-   $
��Left=�6B   $��Bottom=�6]   $��50(�6x   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Tezba+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Cihly+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��Cihly��6�   5�      � 5�      $��1��6   
����� � 5�      �� 5�      $��2* �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5q�6D   $��Pictures/magie.jpg��6O   �� 5�      $��0��6    $��20,10,10,10q�6-   $
��Left=�6B   $��Bottom=�6]   $��50(�6x   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *Magie+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Drahokamy+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��	Drahokamy��6�   5�      � 5�      $��2��6   
������� 5�      �� 5�      $��2* �6(   �� 5�      $��* �6(   .+�5�      �� $��0��6   $
��Left=�6)   $��5q�6D   $��Pictures/jeskyne.jpg��6O   �� 5�      $��0��6    $��20,10,10,10q�6-   $
��Left=�6B   $��Bottom=�6]   $��50(�6x   
��� ���$��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Jeskyne+�� 5�      $��1��6    $
��Left=�6-   $��Center=�6H   $��10,0,0,0q�6c   $��40(�6u   $��Black"�6�   $��Book Antiqua)�6�   ��6�   �� *	Prisery+�� 5�      $��1��6    $��Right=�6-   $��Center=�6I   $��0,0,10,0q�6d   $��30(�6v   $��Black"�6�   $��Book Antiqua)�6�   $��
Příšery��6�   5�      5�      �� 5�      -   5        $��
image_Info��5�      $��1��6&   $��1��63   $	��200��6C   $	��250��6O   ��6\   �� *	KartaInfo+�� 5�      -   5        $��textBlock_Info��5�      $��1��6.   $��1��6;   $��Center=�6K   $��Bottom=�6h   $ 10q�6�   $��40(�6�   $��Book Antiqua)�6�   $��Black"�6�   
���  ��
��� ���$��Vyber kartu k odhození!��6�   $y�Hidden=�6  � 5�      $��1��6   $��1��6     5�      �� 5�      $��* �6'   �� 5�      $��* �6'   .+�5�      � -   5        $��gridVezHrac1��5�      $��0��6+   .+�5�      �� -	   5        $��
vezHrac1_1��5�      $
��Left=�6.   $��Bottom=�6I   $��	50,0,0,60q�6d   $��90��6w   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -
   5        $��
vezHrac1_2��5�      $
��Left=�6.   $��Bottom=�6I   $��	50,0,0,80q�6d   $��90��6w   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��
vezHrac1_3��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,100q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -   5        $��
vezHrac1_4��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,120q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -   5        $��
vezHrac1_5��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,140q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��
vezHrac1_6��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,160q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -   5        $��
vezHrac1_7��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,180q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -   5        $��
vezHrac1_8��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,200q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��
vezHrac1_9��5�      $
��Left=�6.   $��Bottom=�6I   $��
50,0,0,220q�6d   $��90��6x   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��vezHrac1_10��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,240q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -   5        $��vezHrac1_11��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,260q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��vezHrac1_12��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,280q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -   5        $��vezHrac1_13��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,300q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -   5        $��vezHrac1_14��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,320q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��vezHrac1_15��5�      $
��Left=�6/   $��Bottom=�6J   $��
50,0,0,340q�6e   $��90��6y   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -   5        $��vezHrac1_strecha��5�      $
��Left=�64   $��Bottom=�6O   $��
25,0,0,360q�6j   $	��140��6~   $	��140��6�   $��Pictures/vez_strecha1.png��6�   �� 5�      -   5        $��
zedHrac1_1��5�      $
��Left=�6.   $��Bottom=�6I   $��
200,0,0,60q�6d   $��45��6x   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -   5        $��
zedHrac1_2��5�      $
��Left=�6.   $��Bottom=�6I   $��
200,0,0,80q�6d   $��45��6x   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -   5        $��
zedHrac1_3��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,100q�6d   $��45��6y   $��20��6�   $��Pictures/zed3.png��6�   �� 5�      -   5        $��
zedHrac1_4��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,120q�6d   $��45��6y   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -   5        $��
zedHrac1_5��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,140q�6d   $��45��6y   $��20��6�   $��Pictures/zed3.png��6�   �� 5�      -   5        $��
zedHrac1_6��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,160q�6d   $��45��6y   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -   5        $��
zedHrac1_7��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,180q�6d   $��45��6y   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -    5        $��
zedHrac1_8��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,200q�6d   $��45��6y   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -!   5        $��
zedHrac1_9��5�      $
��Left=�6.   $��Bottom=�6I   $��200,0,0,220q�6d   $��45��6y   $��20��6�   $��Pictures/zed3.png��6�   �� 5�      -"   5        $��zedHrac1_10��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,240q�6e   $��45��6z   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -#   5        $��zedHrac1_11��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,260q�6e   $��45��6z   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -$   5        $��zedHrac1_12��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,280q�6e   $��45��6z   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -%   5        $��zedHrac1_13��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,300q�6e   $��45��6z   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -&   5        $��zedHrac1_14��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,320q�6e   $��45��6z   $��20��6�   $��Pictures/zed3.png��6�   �� 5�      -'   5        $��zedHrac1_15��5�      $
��Left=�6/   $��Bottom=�6J   $��200,0,0,340q�6e   $��45��6z   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -(   5        $��textBlockVezHrac1��5�       $
��Left=�69   $��Bottom=�6T   $	��100��6o   $��55��6{   $��45,0,0,5q�6�   
���   �
�������$��40(�6�   $��Book Antiqua)�6�    �� TextAlignment$ Center=�6�   $��2��6  ��6�   �� *Vez+6  �� 5�      -)   5        $��textBlockZedHrac1��5�       $
��Left=�69   $��Bottom=�6T   $	��100��6o   $��55��6{   $��	173,0,0,5q�6�   
���   �
�������$��40(�6�   $��Book Antiqua)�6�   $ Center=�6�   $��2��6  ��6�   �� *Zed+6  5�      � 5�      -*   5        $��gridVezHrac2��5�      $��1��6,   .+�5�      �� -+   5        $��
vezHrac2_1��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��	0,0,50,60q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -,   5        $��
vezHrac2_2��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��	0,0,50,80q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      --   5        $��
vezHrac2_3��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,100q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -.   5        $��
vezHrac2_4��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,120q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -/   5        $��
vezHrac2_5��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,140q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -0   5        $��
vezHrac2_6��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,160q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -1   5        $��
vezHrac2_7��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,180q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -2   5        $��
vezHrac2_8��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,200q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -3   5        $��
vezHrac2_9��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,50,220q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -4   5        $��vezHrac2_10��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,240q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek3.png��6�   �� 5�      -5   5        $��vezHrac2_11��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,260q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -6   5        $��vezHrac2_12��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,280q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -7   5        $��vezHrac2_13��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,300q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek1.png��6�   �� 5�      -8   5        $��vezHrac2_14��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,320q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -9   5        $��vezHrac2_15��5�      $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��
0,0,50,340q�6�   $��90��6�   $��20��6�   $��Pictures/vez_dilek2.png��6�   �� 5�      -:   5        $��vezHrac2_strecha��5�      $��1��64   $��1��6A   $��Right=�6Q   $��Bottom=�6m   $��
0,0,25,360q�6�   $	��140��6�   $	��140��6�   $��Pictures/vez_strecha2.png��6�   �� 5�      -;   5        $��
zedHrac2_1��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,200,60q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5�      -<   5        $��
zedHrac2_2��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��
0,0,200,80q�6�   $��45��6�   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -=   5        $��
zedHrac2_3��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,100q�6�   $��45��6�   $��20��6�   $��Pictures/zed3.png��6�   �� 5�      ->   5        $��
zedHrac2_4��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,120q�6�   $��45��6�   $��20��6�   $��Pictures/zed2.png��6�   �� 5�      -?   5        $��
zedHrac2_5��5�      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,140q�6�   $��45��6�   $��20��6�   $��Pictures/zed3.png��6�   �� 5      -@   5        $��
zedHrac2_6��5      $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,160q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5     -A   5        $��
zedHrac2_7��5     $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,180q�6�   $��45��6�   $��20��6�   $��Pictures/zed2.png��6�   �� 5     -B   5        $��
zedHrac2_8��5     $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,200q�6�   $��45��6�   $��20��6�   $��Pictures/zed2.png��6�   �� 5     -C   5        $��
zedHrac2_9��5     $��1��6.   $��1��6;   $��Right=�6K   $��Bottom=�6g   $��0,0,200,220q�6�   $��45��6�   $��20��6�   $��Pictures/zed3.png��6�   �� 5     -D   5        $��zedHrac2_10��5     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,240q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5     -E   5        $��zedHrac2_11��5     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,260q�6�   $��45��6�   $��20��6�   $��Pictures/zed2.png��6�   �� 5     -F   5        $��zedHrac2_12��5     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,280q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5     -G   5        $��zedHrac2_13��5     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,300q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5     -H   5        $��zedHrac2_14��5     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,320q�6�   $��45��6�   $��20��6�   $��Pictures/zed3.png��6�   �� 5	     -I   5        $��zedHrac2_15��5	     $��1��6/   $��1��6<   $��Right=�6L   $��Bottom=�6h   $��0,0,200,340q�6�   $��45��6�   $��20��6�   $��Pictures/zed1.png��6�   �� 5
     -J   5        $��textBlockVezHrac2��5
      $��Right=�69   $��Bottom=�6U   $	��100��6p   $��55��6|   $��0,0,45,5q�6�   
���   �
�������$��40(�6�   $��Book Antiqua)�6�   $ Center=�6�   ��6�   �� *Vez+�� 5     -K   5        $��textBlockZedHrac2��5      $��Right=�69   $��Bottom=�6U   $	��100��6p   $��55��6|   $��	0,0,173,5q�6�   
���   �
�������$��40(�6�   $��Book Antiqua)�6�   $ Center=�6�   ��6   �� *Zed+5     5     5     �� 5  
   $��0��6   $
��Left=�6   $	��530��68   $��Bottom=�6D   $��10��6_   $��Pictures/bar.png��6k   $
��Fill=�6�   �� 5  
   $��0��6   $��Right=�6   $	��530��69   $��Bottom=�6E   $��10��6`   $��Pictures/bar.png��6l   $
��Fill=�6�   � 5  
   -L   5        $��	gridCards��5     $��2��6     5     �� 5     $��* �6#   �� 5     $��* �6#   �� 5     $��* �6#   �� 5     $��* �6#   �� 5     $��* �6#   .+�5     �� -M   5        $��buttonCard1��5     $��0��6(   $	��200��68   $	��250��6D   #���  6�   ��5     �� 5      6!   �� *Karta1+5     �� 5     -N   5        $��buttonCard2��5     $��1��6(   $	��200��68   $	��250��6D   #���  6�   ��5     �� 5       6!   �� *Karta2+5"     �� 5#     -O   5        $��buttonCard3��5#     $��2��6(   $	��200��68   $	��250��6D   #���  6�   ��5$     �� 5%      6!   �� *Karta3+5'     �� 5(     -P   5        $��buttonCard4��5(     $��3��6(   $	��200��68   $	��250��6D   #���  6�   ��5)     �� 5*      6!   �� *Karta4+5,     �� 5-     -Q   5        $��buttonCard5��5-     $��4��6(   $	��200��68   $	��250��6D   #���  6�   ��5.     �� 5/      6!   �� *Karta5+51     �� 52     -R   5        $��buttonBackground��52     $��4��6-   $��0,0,0,15q�6=   $��50��6O   $��50��6Z   $��Right=�6f   $��Bottom=�6�   
������ #���  6�   ��53     �� 54     $ Pictures/rune_ico1.png��6!   56     57     58     59     