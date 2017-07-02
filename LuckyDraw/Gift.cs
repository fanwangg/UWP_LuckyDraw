﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace FY18LuckyDraw
{
   public class Gift : INotifyPropertyChanged
   {
      public static List<Gift> Gifts = new List<Gift>();
      public static int TotalGiftNumber;
      public static Gift curGift;
      private static int curGiftIndex;


      private string _name;
      private int _quantity;
      private string _prize;

      public string Name
      {
         get
         {
            return _name;
         }
         set
         {
            if( !value.Equals( _name ) )
            {
               _name = value;
               NotifyPropertyChanged( "Name" );
            }
         }
      }

      public int Quantity
      {
         get
         {
            return _quantity;
         }
         set
         {
            if( !value.Equals( _quantity ) )
            {
               _quantity = value;
               NotifyPropertyChanged( "Quantity" );
            }
         }
      }

      public string Prize
      {
         get
         {
            return _prize;
         }
         set
         {
            if( !value.Equals( _prize ) )
            {
               _prize = value;
               NotifyPropertyChanged( "Prize" );
            }
         }
      }

      public static void Init()
      {
         TotalGiftNumber = Gifts.Count;
         if( TotalGiftNumber > 0 )
         {
            curGift = Gifts[ 0 ];
            curGiftIndex = 0;
         }
      }
      public void Output()
      {
         //output current Gift

         return;
      }

      public static void GetNext()
      {
         curGiftIndex++;
         if( curGiftIndex < TotalGiftNumber )
         {
            curGift = Gifts[ curGiftIndex ];
         }
         else
            curGift = null;  
      }


      public event PropertyChangedEventHandler PropertyChanged;
      private void NotifyPropertyChanged( string propertyName )
      {
         PropertyChangedEventHandler handler = PropertyChanged;
         if( null != handler )
         {
            handler( this, new PropertyChangedEventArgs( propertyName ) );
         }
      }
   }
}
