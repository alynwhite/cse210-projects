using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation1 World!");
        Random rnd_count = new Random();
        int rnd_video = rnd_count.Next(3,5);
        int rnd_comments = rnd_count.Next(3, 6);
        List<Video> vidoesList = new List<Video> {};
        for(int i = 0; i < rnd_video; i++){
            Video v1 = new Video();
            for(int x = 0; x < rnd_comments; x++){
                Comment c1 = new Comment();
                CreateComments(c1);
                v1.AddComment(c1);
            }
            CreateVideos(v1);
            vidoesList.Add(v1);
        }

        for(int l = 0; l < vidoesList.Count; l++){
            vidoesList[l].DisplayVideo();
        }
        


    }

    static void CreateComments(Comment c1){
        List<string> commentsName = new List<string>{"JohnDoe123", "marine_girl88", "techy_tim", "FutureTechFan", "Alex_Innovator", "science_lover", "PastaQueen", "HomeCook78", "foodie_girl", "gym_guru1234", "fitfanatic", "workout_wonder", "historyBuff", "ancient_enthusiast"};

        List<string> commentsMade = new List<string>{"I love the details about the burial rituals. Incredible research!","I always wondered what the hieroglyphs meant. Thanks for explaining!", "So fascinating! I had no idea the pyramids were built using such advanced techniques.",  "I appreciate the clear instructions on each exercise. Really helpful.", "Is there a follow-up video for advanced routines? I'd love to challenge myself more.",   "This routine is a game-changer. My fitness level has improved so much!",  "I tried this recipe, and it was delicious! My family loved it.", "Absolutely loved this video, I learned so much!", "This was incredible! The visuals were stunning.", "I can't believe I didn't know about this before. Thanks for sharing!", "Wow, this really made me think about things differently.", "I need more videos like this! Keep it up!", "Such a great explanation, I feel like I understand it so much better now.", "This video is pure gold. I watched it three times!", "The ending gave me chills, what a plot twist!", "So inspiring. I can't wait to try this out myself!", "This was super helpful, thank you for breaking it down so simply.", "I love how you explained the concept in such detail, makes it so easy to understand.", "Youve got a new subscriber, this content is amazing!", "Im going to share this with all my friends, they need to see this.", "This was such an eye-opener. I never knew this before.", "Please make more videos on this topic, Im hooked!", "I cant stop rewatching this, its so good!", "This video made my day. Im so glad I found it!", "The production quality is outstanding, I can tell you put a lot of effort into this.", "Im blown away, this was so well done.", "This is what the internet should be full of—great content!", "I never expected such a deep dive into this subject, wow!", "Fantastic job! Cant wait for your next video.", "This is definitely going to help me with my project. Thank you!", "So much detail, its like you really care about your audience.", "I shared this on my social media, hoping more people see it!", "Incredible research, I didnt know half of this.", "I could watch a whole series on this topic!", "I came for the information, stayed for the amazing editing!"};

        Random rnd = new Random();
        int name_index = rnd.Next(commentsName.Count);
        int comments_index = rnd.Next(commentsMade.Count);

        c1._name = commentsName[name_index];
        c1._commentText = commentsMade[comments_index];

    }

    static void CreateVideos( Video v1){
        List<string> videoAuthor = new List<string>{
            "Liаm Stonebrook", "Sophia Winters", "Ethan Blackwood", "Isabella Sterling", "Maximus Drake", "Olivia Hawthorne", "Alexander Crest", "Maya Rivers", "Julian Foxwell", "Chloe Kensington", "Grayson O’Malley", "Ava Everhart", "Noah Wilder", "Charlotte Montgomery", "Theo Westbrook", "Emma Kingsley", "Landon Steele", "Madeline Blackwell", "Jameson Pierce", "Sienna Aldridge", "Hudson Vaughn", "Vivian Lancaster", "Logan Sinclair", "Penelope Graves", "Finnley West", "Hazel Donovan", "Quinn Bennett", "Daphne Lockwood", "Julian Sterling", "Ruby Ashton"
        };

        List <string> videoTitle = new List<string>{
            "Whispers of the Forgotten", "Beyond the Horizon", "Echoes in the Dark", "The Last Ember", "Mysteries of the Old World", "Through the Veil", "Shadows of the Past", "The Midnight Realm", "A Dance with Time", "The Lost Kingdom", "Wings of the Silent Sky", "Beneath the Silver Moon", "The Enchanted Forest", "The Awakening Storm", "Voices from the Abyss", "The Final Countdown", "Secrets of the Deep", "Rising from Ashes", "The Edge of Eternity", "The Timekeeper's Curse", "Starlight in the Storm", "Into the Unknown", "The Crimson Pact", "Whispers in the Wind", "The Shadow's Embrace", "The Heart of the Wolf", "Revelations of the Hidden", "The Forgotten Prophecy", "Darkness Beneath the Surface", "The Infinite Journey", "Veins of the Earth"
        };

        List <int> videoLength = new List<int>{
            30, 100, 41230, 13021, 320, 1230, 12, 12302, 1312, 132,1321312, 543, 53456, 56765756, 564652, 156198, 15861, 1988491, 23121, 98127189
        };

        Random rnd = new Random();
        int author_index = rnd.Next(videoAuthor.Count);
        int title_index = rnd.Next(videoTitle.Count);
        int length_index = rnd.Next(videoLength.Count);

        v1._author = videoAuthor[author_index];
        v1._title = videoTitle[title_index];
        v1._videoLength = videoLength[length_index];
    }
}