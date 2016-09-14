using System;
using System.Collections.Generic;

namespace Sample
{
    public class Contact
    {
        private string index;
        private string name;

        public Contact(string index, string name)
        {
            this.index = index;
            this.name = name;
        }

        public string getIndex()
        {
            return index;
        }

        public string getName()
        {
            return name;
        }

        public static List<Contact> getEnglishContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("A", "Abbey"));
            contacts.Add(new Contact("A", "Alex"));
            contacts.Add(new Contact("A", "Amy"));
            contacts.Add(new Contact("A", "Anne"));
            contacts.Add(new Contact("B", "Betty"));
            contacts.Add(new Contact("B", "Bob"));
            contacts.Add(new Contact("B", "Brian"));
            contacts.Add(new Contact("C", "Carl"));
            contacts.Add(new Contact("C", "Candy"));
            contacts.Add(new Contact("C", "Carlos"));
            contacts.Add(new Contact("C", "Charles"));
            contacts.Add(new Contact("C", "Christina"));
            contacts.Add(new Contact("D", "David"));
            contacts.Add(new Contact("D", "Daniel"));
            contacts.Add(new Contact("E", "Elizabeth"));
            contacts.Add(new Contact("E", "Eric"));
            contacts.Add(new Contact("E", "Eva"));
            contacts.Add(new Contact("F", "Frances"));
            contacts.Add(new Contact("F", "Frank"));
            contacts.Add(new Contact("I", "Ivy"));
            contacts.Add(new Contact("J", "James"));
            contacts.Add(new Contact("J", "John"));
            contacts.Add(new Contact("J", "Jessica"));
            contacts.Add(new Contact("K", "Karen"));
            contacts.Add(new Contact("K", "Karl"));
            contacts.Add(new Contact("K", "Kim"));
            contacts.Add(new Contact("L", "Leon"));
            contacts.Add(new Contact("L", "Lisa"));
            contacts.Add(new Contact("P", "Paul"));
            contacts.Add(new Contact("P", "Peter"));
            contacts.Add(new Contact("S", "Sarah"));
            contacts.Add(new Contact("S", "Steven"));
            contacts.Add(new Contact("R", "Robert"));
            contacts.Add(new Contact("R", "Ryan"));
            contacts.Add(new Contact("T", "Tom"));
            contacts.Add(new Contact("T", "Tony"));
            contacts.Add(new Contact("W", "Wendy"));
            contacts.Add(new Contact("W", "Will"));
            contacts.Add(new Contact("W", "William"));
            contacts.Add(new Contact("Z", "Zoe"));
            return contacts;
        }

        public static List<Contact> getChineseContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("B", "白虎"));
            contacts.Add(new Contact("C", "常羲"));
            contacts.Add(new Contact("C", "嫦娥"));
            contacts.Add(new Contact("E", "二郎神"));
            contacts.Add(new Contact("F", "伏羲"));
            contacts.Add(new Contact("G", "观世音"));
            contacts.Add(new Contact("J", "精卫"));
            contacts.Add(new Contact("K", "夸父"));
            contacts.Add(new Contact("N", "女娲"));
            contacts.Add(new Contact("N", "哪吒"));
            contacts.Add(new Contact("P", "盘古"));
            contacts.Add(new Contact("Q", "青龙"));
            contacts.Add(new Contact("R", "如来"));
            contacts.Add(new Contact("S", "孙悟空"));
            contacts.Add(new Contact("S", "沙僧"));
            contacts.Add(new Contact("S", "顺风耳"));
            contacts.Add(new Contact("T", "太白金星"));
            contacts.Add(new Contact("T", "太上老君"));
            contacts.Add(new Contact("X", "羲和"));
            contacts.Add(new Contact("X", "玄武"));
            contacts.Add(new Contact("Z", "猪八戒"));
            contacts.Add(new Contact("Z", "朱雀"));
            contacts.Add(new Contact("Z", "祝融"));
            return contacts;
        }

        public static List<Contact> getJapaneseContacts()
        {
            List<Contact> contacts = new List<Contact>();
            contacts.Add(new Contact("あ", "江户川コナン"));
            contacts.Add(new Contact("あ", "油女シノ"));
            contacts.Add(new Contact("あ", "犬夜叉"));
            contacts.Add(new Contact("か", "旗木カカシ"));
            contacts.Add(new Contact("か", "神楽"));
            contacts.Add(new Contact("か", "黒崎一護"));
            contacts.Add(new Contact("さ", "桜木花道"));
            contacts.Add(new Contact("さ", "坂田銀時"));
            contacts.Add(new Contact("さ", "殺生丸"));
            contacts.Add(new Contact("な", "奈良シカマル"));
            contacts.Add(new Contact("は", "旗木カカシ"));
            contacts.Add(new Contact("は", "日向ネジ"));
            contacts.Add(new Contact("や", "越前リョーマ"));
            contacts.Add(new Contact("や", "野比のび太"));
            contacts.Add(new Contact("や", "野原しんのすけ"));
            contacts.Add(new Contact("ら", "流川楓"));
            return contacts;
        }
    }
}

