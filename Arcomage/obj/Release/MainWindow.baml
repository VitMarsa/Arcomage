   M S B A M L   `   `   `  ���� C  ?Arcomage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ArcomageArcomage      Arcomage.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     (localclr-namespace:Arcomage       � Title$  Arcomage��$
��1000��$
��1000�� � WindowStartupLocation$ CenterScreen=�$
��1000��$
��1000�� � Icon$ Pictures/arcomage.ico�� � 	Resources    FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 	playStyle	 �� 
TargetType
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 N     &	 c     &	 x     &	 �     &	 �     &	 �     &	 �     &	 �     &		 �     &	
     7   7  7  7  7  7 	 �� .���  � �� �� .R��� $��2q� . #��� ��$��1��$	 1 2R��� $ 	#FFDDDDDD���� $ 	#FF707070���� $ 	#FFBEE6FD���� $ 	#FF3C7FB1���� $ 	#FFC4E5F6���� $ 	#FF2C628B���� $ 	#FFF4F4F4���� $ 	#FFADB2B5���� $ 	#FF838383���� "	 ��.���  �@�FocusVisualStyle8   ��  � ��8  ��  � ��8  ��  � ��# � ����  � ��$ 1q���  � ��$ Center=���  � ��$ Center=���  � ��$ 1q���  � �� �� "
 ��.R��� $ border��#��z��#��z��#��z�� . ._��� $ contentPresenter��|�.  #��z��#��z����. # z #��z�� P�  �@��IsDefaulted . . ��� $ border��# � �� � ��P�  �@J�IsMouseOver . P�  � �� . P�  � {� .  . ��� $ border��8   � ���� $ border��8   � ���� $ contentPresenter��8   � ��.��� 
���   �$��0q� � RowDefinitions �� $	��180 ��� $��* �.+��� $��0��$!��Pictures/arcomage_title.jpg��� $��1��$��15q� �� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $��* ��� $	��160 �.+�� $��0��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$!��Startovní velikost věže:���� -   $��textBox_StartovniVez��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(� �� TextAlignment$ Center=�$��Book Antiqua)�$
��Bold"�$��15��� $��1��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$!��Startovní velikost hradby:���� -   $��textBox_StartovniZed��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��5��� $��2��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Startovní těžba:���� -   $��textBox_StartovniTezba��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��2��� $��3��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Startovní magie:���� -   $��textBox_StartovniMagie��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��2��� $��4��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Startovní jeskyně:���� -   $��textBox_StartovniJeskyne��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��2��� $��5��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Startovní počet cihel:���� -   $��textBox_StartovniCihly��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��10��� $��6��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$#��Startovní počet drahokamů:���� -   $ ��textBox_StartovniDrahokamy��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��10��� $��7��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$"��Startovní počet příšer:���� -   $��textBox_StartovniPrisery��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��10��� $��8��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$!��Vítězná velikost věže:���� -	   $��textBox_VitezstviVez��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��50��� $��9��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$ ��Vítězný počet surovin:���� -
   $��textBox_VitezstviSuroviny��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$	��150��� $��10��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Jméno prvního hráče:���� -   $��textBox_Hrac1Jmeno��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��Sirael��� $��11��$	��550��
���  ��$��Center=�$��Center=�.+��� $��5q�$��25(�$��Book Antiqua)�$
��Bold"�$��Jméno druhého hráče:���� -   $��textBox_Hrac2Jmeno��$��Right=�$��5,5,5,5q�$	��200��
���  ��
���  ��$��25(�$ Center=�$��Book Antiqua)�$
��Bold"�$��Glóin���� -   $��checkBox_AI��$��Right=�$��0,0,25,0q�$��Center=�$��25��$��25�� d� 	IsChecked$ falseY��� $��Right=�$��Center=�$��	0,0,10,10q�$��15(�$��Black"�$��Book Antiqua)�$��AI���� -   $��button_Play��$��12��$��5q�$	��150��$	��150��
���   �#��� 
 ����  �� ImageSource$ Pictures/button_play.png��