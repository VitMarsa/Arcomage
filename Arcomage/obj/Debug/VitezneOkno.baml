   M S B A M L   `   `   `  ����C  ?Arcomage, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ArcomageArcomage  5   	       Arcomage.VitezneOkno   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Arcomage     5   	     � Title$  Arcomage��5   	   $	��450��6   $	��450��6'   $	��450��67   $	��470��6G   $	��470��6S   $	��470��6b   
���   � � WindowStartupLocation$ CenterScreen=�6�    � Icon$ Pictures/arcomage.ico��6�    � 	Resources 5	         FocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  Button.Static.Background �� Color  Button.Static.Border  Button.MouseOver.Background  Button.MouseOver.Border  Button.Pressed.Background  Button.Pressed.Border  Button.Disabled.Background  Button.Disabled.Border 	 Button.Disabled.Foreground 
 okStyle	 �� 
TargetType
 �� 
TargetType ��Name ��Name �� Triggers P� Property P� Value �� 
TargetName��%�  &	        &	 �     &	 �     &	 �     &	     &	 6    &	 Y    &	 |    &	 �    &		 �    &	
 �    7   7  7  7  7  7  7  7 	 �� 5
   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $ 	#FFDDDDDD��6;   �� 5   
   $ 	#FF707070��67   �� 5   
   $ 	#FFBEE6FD��6>   �� 5   
   $ 	#FF3C7FB1��6:   �� 5   
   $ 	#FFC4E5F6��6<   �� 5   
   $ 	#FF2C628B��68   �� 5   
   $ 	#FFF4F4F4��6=   �� 5   
   $ 	#FFADB2B5��69   �� 5   
   $ 	#FF838383��6=   �� 5   
   "	 ��6    .�5      ��  �@�FocusVisualStyle8   61   �� 5       � ��8  6+   �� 5       � ��8  6,   �� 5        � ��# � ��6+   �� 5!       � ��$ 1q�60   �� 5"       � ��$ Center=�6;   �� 5#       � ��$ Center=�69   �� 5$       � ��$ 1q�6(   �� 5%       � �� 5&      �� 5'      "
 ��6&   .R�5(      �� $ border��6!   #��z��61   #��z��6]   #��z��6�    . ._�5)      �� $ contentPresenter��6/   |�.  #��z��6[   #��z��6�   ��. # z 6�   #��z��6  5*       5+      P� 5,       �@��IsDefaulted . . �5-   "   �� $ border��6@   # � ��6T    � ��5.      P� 5/       �@J�IsMouseOver . . �50   "   �� $ border��6@   8   � ��6T   51      P� 52       � �� . . �53   "   �� $ border��6@   8   � ��6T   54      P� 55       � {� .  . �56   "   �� $ border��6?   8   � ��6S   �� 57   "   $ border��6@   8   � ��6T   �� 58   "   $ contentPresenter��6K   8   � ��6i   59      5;      5=      5>      5?      .��5@      � $��20q�6    � RowDefinitions 5A   
   �� 5B      $��60 �6   �� 5C      $��85 �6   �� 5D      $	��150 �6   �� 5E      $��85 �6   ��5G   
   �� 5H       �� ImageSource$% Pictures/victory_background.png��6   .+�5J   
   �� -   5        $��textBlock_Hrac1��5J      $��0��6+   $
��Left=�68   $��Bottom=�6S   $��90,0,0,0q�6n   $��20(�6�   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Jméno��6�   �� 5K   
   -   5        $��textBlock_Hrac2��5K      $��0��6+   $��Right=�68   $��Bottom=�6T   $��0,0,90,0q�6o   $��20(�6�   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Jméno��6�   �� 5L   
   -   5        $��textBlock_Vitez_Hrac1��5L      $��1��61   $
��Left=�6>   $��Bottom=�6Y   $��15,0,0,0q�6t   $��20(�6�   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Vítěz��6�   �� 5M   
   -   5        $��textBlock_Vitez_Hrac2��5M      $��1��61   $��Right=�6>   $��Bottom=�6Z   $��0,0,15,0q�6u   $��20(�6�   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Poražen��6�   �� 5N   
   $��2��6   $��Center=�6!   $��Bottom=�6>   $��0,0,0,30q�6Y   $��30(�6k   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Vítězství��6�   �� 5O   
   -   5        $��textBlock_ZpusobVitezstvi��5O      $��2��65   $��Center=�6B   $��Bottom=�6_   $��0,0,0,5q�6z   $��15(�6�   
��� ���$��Book Antiqua)�6�   $
��Bold"�6�   $��Zničením věže��6�   �� 5P   
   -   5        $��3��5P      $��65��6   $��35��6)   #��� 
 6J   ��5Q      �� 5R      $ Pictures/ok_button.png��6   5T      5U      5V      