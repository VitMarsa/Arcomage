   M S B A M L   `   `   `  ���� C  ?Arcomage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ArcomageArcomage      Arcomage.HerniObrazovka   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Arcomage       � Title$  Arcomage��$	��900��$
��1600��$	��900��$
��1600��
���   � � WindowStartupLocation$ CenterScreen=� � Icon$ Pictures/arcomage.ico�� � 	Resources    	rune_icon �� ImageSource  FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background	 �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background 	 Button.Disabled.Border 
 Button.Disabled.Foreground  cardButtonStyle
 �� 
TargetType �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName  Button.MouseOver.Border2  runeIcoStyle��%�  &	        &	 "     &	 p     &	 �     &	 �     &	 �     &	 �     &	 �     &	 �     &		     &	
     &	 +    7  7  7  7  7  7  &	 e    &	 z    7  7  7  7   7  7  7  7 	 7 
 �� $ Pictures/rune_ico2.png���� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $	 	#FFDDDDDD���� $	 	#FF707070���� $	 	#FFBEE6FD���� $	 DarkRed���� $	 	#FFC4E5F6���� $	 	#FF2C628B���� $	 	#FFF4F4F4���� $	 	#FFADB2B5���� $	 	#FF838383���� "
 ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ���� $	 	#FF3C7FB1���� "
 ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� " ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . . ��� $ border��8   � ��P�  � �� . . ��� $ border��8   � ���� $ border��8   � ��P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� -   $��gridMain��$��20q�����  �� *Backgrounds+ � RowDefinitions �� $��2* ��� $��* �.+�� $��0�� � ColumnDefinitions �� $	��250 ��� $��* ��� $	��250 � �� $��50 ��� $��* �.+��� -   $��textblock_jmenoHrace1��$��0��$��0�� �� Padding$ 5q�$��Center=�$
��Left=�$��30(�$
��Bold"�
���   �$��Book Antiqua)�
��� ���$�� ���� -   $��textblock_jmenoHrace2��$��0��$��2��$ 5q�$��Center=�$��Right=�$��30(�$
��Bold"�
���   �$��Book Antiqua)�
��� ���$�� ��� -   $��	gridHrac1��$��1��$��0�� �� $��* ��� $��* ��� $��* �.+�� $��0��
���  �� �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5q�$��Pictures/lom.jpg���� $��0��$��20,10,10,10q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *Tezba+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *Cihly+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��Cihly��� $��1��
����� � �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5q�$��Pictures/magie.jpg���� $��0��$��20,10,10,10q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *Magie+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *	Drahokamy+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��	Drahokamy��� $��2��
������� �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5,5,0,5q�$��Pictures/jeskyne.jpg��$��2���� $��0��$��20,0,0,9q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *	Jeskyne+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *	Prisery+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��
Příšery��$��2��� -   $��	gridHrac2��$��1��$��2�� �� $��* ��� $��* ��� $��* �.+�� $��0��
���  �� �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5q�$��Pictures/lom.jpg���� $��0��$��20,10,10,10q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *Tezba+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *Cihly+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��Cihly��� $��1��
����� � �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5q�$��Pictures/magie.jpg���� $��0��$��20,10,10,10q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *Magie+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *	Drahokamy+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��	Drahokamy��� $��2��
������� �� $��2* ��� $��* �.+��� $��0��$
��Left=�$��5q�$��Pictures/jeskyne.jpg���� $��0��$��20,10,10,10q�$
��Left=�$��Bottom=�$��50(�
��� ���$��Black"�$��Book Antiqua)����� *	Jeskyne+�� $��1��$
��Left=�$��Center=�$��10,0,0,0q�$��40(�$��Black"�$��Book Antiqua)����� *	Prisery+�� $��1��$��Right=�$��Center=�$��0,0,10,0q�$��30(�$��Black"�$��Book Antiqua)�$��
Příšery���� -   $��
image_Info��$��1��$��1��$	��200��$	��250������ *	KartaInfo+�� -   $��textBlock_Info��$��1��$��1��$��Center=�$��Bottom=�$ 10q�$��40(�$��Book Antiqua)�$��Black"�
���  ��
��� ���$��Vyber kartu k odhození!��$y�Hidden=�� $��1��$��1�� �� $��* ��� $��* �.+�� -   $��gridVezHrac1��$��0��.+��� -	   $��
vezHrac1_1��$
��Left=�$��Bottom=�$��	50,0,0,60q�$��90��$��20��$��Pictures/vez_dilek1.png���� -
   $��
vezHrac1_2��$
��Left=�$��Bottom=�$��	50,0,0,80q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��
vezHrac1_3��$
��Left=�$��Bottom=�$��
50,0,0,100q�$��90��$��20��$��Pictures/vez_dilek3.png���� -   $��
vezHrac1_4��$
��Left=�$��Bottom=�$��
50,0,0,120q�$��90��$��20��$��Pictures/vez_dilek3.png���� -   $��
vezHrac1_5��$
��Left=�$��Bottom=�$��
50,0,0,140q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��
vezHrac1_6��$
��Left=�$��Bottom=�$��
50,0,0,160q�$��90��$��20��$��Pictures/vez_dilek1.png���� -   $��
vezHrac1_7��$
��Left=�$��Bottom=�$��
50,0,0,180q�$��90��$��20��$��Pictures/vez_dilek1.png���� -   $��
vezHrac1_8��$
��Left=�$��Bottom=�$��
50,0,0,200q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��
vezHrac1_9��$
��Left=�$��Bottom=�$��
50,0,0,220q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��vezHrac1_10��$
��Left=�$��Bottom=�$��
50,0,0,240q�$��90��$��20��$��Pictures/vez_dilek3.png���� -   $��vezHrac1_11��$
��Left=�$��Bottom=�$��
50,0,0,260q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��vezHrac1_12��$
��Left=�$��Bottom=�$��
50,0,0,280q�$��90��$��20��$��Pictures/vez_dilek1.png���� -   $��vezHrac1_13��$
��Left=�$��Bottom=�$��
50,0,0,300q�$��90��$��20��$��Pictures/vez_dilek1.png���� -   $��vezHrac1_14��$
��Left=�$��Bottom=�$��
50,0,0,320q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��vezHrac1_15��$
��Left=�$��Bottom=�$��
50,0,0,340q�$��90��$��20��$��Pictures/vez_dilek2.png���� -   $��vezHrac1_strecha��$
��Left=�$��Bottom=�$��
25,0,0,360q�$	��140��$	��140��$��Pictures/vez_strecha1.png���� -   $��
zedHrac1_1��$
��Left=�$��Bottom=�$��
200,0,0,60q�$��45��$��20��$��Pictures/zed1.png���� -   $��
zedHrac1_2��$
��Left=�$��Bottom=�$��
200,0,0,80q�$��45��$��20��$��Pictures/zed2.png���� -   $��
zedHrac1_3��$
��Left=�$��Bottom=�$��200,0,0,100q�$��45��$��20��$��Pictures/zed3.png���� -   $��
zedHrac1_4��$
��Left=�$��Bottom=�$��200,0,0,120q�$��45��$��20��$��Pictures/zed2.png���� -   $��
zedHrac1_5��$
��Left=�$��Bottom=�$��200,0,0,140q�$��45��$��20��$��Pictures/zed3.png���� -   $��
zedHrac1_6��$
��Left=�$��Bottom=�$��200,0,0,160q�$��45��$��20��$��Pictures/zed1.png���� -   $��
zedHrac1_7��$
��Left=�$��Bottom=�$��200,0,0,180q�$��45��$��20��$��Pictures/zed2.png���� -    $��
zedHrac1_8��$
��Left=�$��Bottom=�$��200,0,0,200q�$��45��$��20��$��Pictures/zed2.png���� -!   $��
zedHrac1_9��$
��Left=�$��Bottom=�$��200,0,0,220q�$��45��$��20��$��Pictures/zed3.png���� -"   $��zedHrac1_10��$
��Left=�$��Bottom=�$��200,0,0,240q�$��45��$��20��$��Pictures/zed1.png���� -#   $��zedHrac1_11��$
��Left=�$��Bottom=�$��200,0,0,260q�$��45��$��20��$��Pictures/zed2.png���� -$   $��zedHrac1_12��$
��Left=�$��Bottom=�$��200,0,0,280q�$��45��$��20��$��Pictures/zed1.png���� -%   $��zedHrac1_13��$
��Left=�$��Bottom=�$��200,0,0,300q�$��45��$��20��$��Pictures/zed1.png���� -&   $��zedHrac1_14��$
��Left=�$��Bottom=�$��200,0,0,320q�$��45��$��20��$��Pictures/zed3.png���� -'   $��zedHrac1_15��$
��Left=�$��Bottom=�$��200,0,0,340q�$��45��$��20��$��Pictures/zed1.png���� -(   $��textBlockVezHrac1��$
��Left=�$��Bottom=�$	��100��$��55��$��45,0,0,5q�
���   �
�������$��40(�$��Book Antiqua)� �� TextAlignment$ Center=�$��2������ *Vez+�� -)   $��textBlockZedHrac1��$
��Left=�$��Bottom=�$	��100��$��55��$��	173,0,0,5q�
���   �
�������$��40(�$��Book Antiqua)�$ Center=�$��2������ *Zed+� -*   $��gridVezHrac2��$��1��.+��� -+   $��
vezHrac2_1��$��1��$��1��$��Right=�$��Bottom=�$��	0,0,50,60q�$��90��$��20��$��Pictures/vez_dilek1.png���� -,   $��
vezHrac2_2��$��1��$��1��$��Right=�$��Bottom=�$��	0,0,50,80q�$��90��$��20��$��Pictures/vez_dilek2.png���� --   $��
vezHrac2_3��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,100q�$��90��$��20��$��Pictures/vez_dilek3.png���� -.   $��
vezHrac2_4��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,120q�$��90��$��20��$��Pictures/vez_dilek3.png���� -/   $��
vezHrac2_5��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,140q�$��90��$��20��$��Pictures/vez_dilek2.png���� -0   $��
vezHrac2_6��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,160q�$��90��$��20��$��Pictures/vez_dilek1.png���� -1   $��
vezHrac2_7��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,180q�$��90��$��20��$��Pictures/vez_dilek1.png���� -2   $��
vezHrac2_8��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,200q�$��90��$��20��$��Pictures/vez_dilek2.png���� -3   $��
vezHrac2_9��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,220q�$��90��$��20��$��Pictures/vez_dilek2.png���� -4   $��vezHrac2_10��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,240q�$��90��$��20��$��Pictures/vez_dilek3.png���� -5   $��vezHrac2_11��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,260q�$��90��$��20��$��Pictures/vez_dilek2.png���� -6   $��vezHrac2_12��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,280q�$��90��$��20��$��Pictures/vez_dilek1.png���� -7   $��vezHrac2_13��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,300q�$��90��$��20��$��Pictures/vez_dilek1.png���� -8   $��vezHrac2_14��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,320q�$��90��$��20��$��Pictures/vez_dilek2.png���� -9   $��vezHrac2_15��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,50,340q�$��90��$��20��$��Pictures/vez_dilek2.png���� -:   $��vezHrac2_strecha��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,25,360q�$	��140��$	��140��$��Pictures/vez_strecha2.png���� -;   $��
zedHrac2_1��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,200,60q�$��45��$��20��$��Pictures/zed1.png���� -<   $��
zedHrac2_2��$��1��$��1��$��Right=�$��Bottom=�$��
0,0,200,80q�$��45��$��20��$��Pictures/zed2.png���� -=   $��
zedHrac2_3��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,100q�$��45��$��20��$��Pictures/zed3.png���� ->   $��
zedHrac2_4��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,120q�$��45��$��20��$��Pictures/zed2.png���� -?   $��
zedHrac2_5��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,140q�$��45��$��20��$��Pictures/zed3.png���� -@   $��
zedHrac2_6��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,160q�$��45��$��20��$��Pictures/zed1.png���� -A   $��
zedHrac2_7��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,180q�$��45��$��20��$��Pictures/zed2.png���� -B   $��
zedHrac2_8��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,200q�$��45��$��20��$��Pictures/zed2.png���� -C   $��
zedHrac2_9��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,220q�$��45��$��20��$��Pictures/zed3.png���� -D   $��zedHrac2_10��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,240q�$��45��$��20��$��Pictures/zed1.png���� -E   $��zedHrac2_11��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,260q�$��45��$��20��$��Pictures/zed2.png���� -F   $��zedHrac2_12��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,280q�$��45��$��20��$��Pictures/zed1.png���� -G   $��zedHrac2_13��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,300q�$��45��$��20��$��Pictures/zed1.png���� -H   $��zedHrac2_14��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,320q�$��45��$��20��$��Pictures/zed3.png���� -I   $��zedHrac2_15��$��1��$��1��$��Right=�$��Bottom=�$��0,0,200,340q�$��45��$��20��$��Pictures/zed1.png���� -J   $��textBlockVezHrac2��$��Right=�$��Bottom=�$	��100��$��55��$��0,0,45,5q�
���   �
�������$��40(�$��Book Antiqua)�$ Center=����� *Vez+�� -K   $��textBlockZedHrac2��$��Right=�$��Bottom=�$	��100��$��55��$��	0,0,173,5q�
���   �
�������$��40(�$��Book Antiqua)�$ Center=����� *Zed+�� $��0��$
��Left=�$	��530��$��Bottom=�$��10��$��Pictures/bar.png��$
��Fill=��� $��0��$��Right=�$	��530��$��Bottom=�$��10��$��Pictures/bar.png��$
��Fill=�� -L   $��	gridCards��$��2�� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* �.+��� -M   $��buttonCard1��$��0��$	��200��$	��250��#���  ����  �� *Karta1+�� -N   $��buttonCard2��$��1��$	��200��$	��250��#���  ����  �� *Karta2+�� -O   $��buttonCard3��$��2��$	��200��$	��250��#���  ����  �� *Karta3+�� -P   $��buttonCard4��$��3��$	��200��$	��250��#���  ����  �� *Karta4+�� -Q   $��buttonCard5��$��4��$	��200��$	��250��#���  ����  �� *Karta5+�� -R   $��buttonBackground��$��4��$��0,0,0,15q�$��50��$��50��$��Right=�$��Bottom=�
������ #���  ���� $ Pictures/rune_ico1.png��