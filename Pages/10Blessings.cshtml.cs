using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace church_of_the_emporer_as_messiah.Pages {
    public class TenBlessings : PageModel {
        public string Message {
            get;
            set;
        }
        public string blessing_1 {
            get;
            set;
        }
        public string blessing_2 {
            get;
            set;
        }
        public string blessing_3 {
            get;
            set;
        }
        public string blessing_4 {
            get;
            set;
        }
        public string blessing_5 {
            get;
            set;
        }
        public string blessing_6 {
            get;
            set;
        }
        public string blessing_7 {
            get;
            set;
        }
        public string blessing_8 {
            get;
            set;
        }
        public string blessing_9 {
            get;
            set;
        }
        public string blessing_10 {
            get;
            set;
        }
        public string recitation_1 {
            get;
            set;
        }
        public string recitation_2 {
            get;
            set;
        }
        public string recitation_3 {
            get;
            set;
        }
        public string recitation_4 {
            get;
            set;
        }
        public string recitation_5 {
            get;
            set;
        }
        public string recitation_6 {
            get;
            set;
        }
        public string recitation_7 {
            get;
            set;
        }
        public string recitation_8 {
            get;
            set;
        }
        public string recitation_9 {
            get;
            set;
        }
        public string recitation_10 {
            get;
            set;
        }
        public void OnGet () {
            Message = "The 10 Blessings of the 10 Virtues of Our Faith";
            blessing_1 = "The First Virtue is Faith.";
            recitation_1 = "Recitation: “Faith above all. We must trust God and their chosen Emperor to guide us.” Faith is exemplified by daily prayer, regular attendance of Church ceremonies, dutiful tithing, and pilgrimage to holy sites.";
            blessing_2 = "The Second Virtue is Propriety, which flows from Faith. ";
            recitation_2 = "Recitation: “We must be obedient to tradition, ceremony, courtesy and station.” Propriety is exemplified by respectful loyalty to righteous authority and cultural norms, along with unfailing intolerance for all heretics and heathens. Custom, dress, and technology all must adhere to Propriety.";
            blessing_3 = "The Third Virtue is Justice, which flows from Propriety.";
            recitation_3 = "Recitation: “We must reward those who behave rightly and punish those who do not.” Justice is exemplified by its unflinching enforcement, and we must correct our own failings before looking to those of others.";
            blessing_4 = "The Fourth Virtue is Fortitude, which reinforces Justice. Recitation: “We must patiently endure the challenges laid upon us and follow the rightful path despite them.” Fortitude is exemplified by steadfast courage and endurance in the face of adversity, particularly in avoiding all cringing or complaint when upon holy ground or fulfilling holy duties.";
            recitation_4 = "";
            blessing_5 = "The Fifth Virtue is Wisdom, which accompanies Fortitude. ";
            recitation_5 = "Recitation: “We must strive to see the world in its truth and shape it according to God’s will.” Wisdom is exemplified by perceived the flawed world as it is, but never losing sight of what it should be.  Daily reflection upon the sacred texts and their application to our lives is essential to Wisdom.";
            blessing_6 = "The Sixth Virtue is Temperance, which flows from Wisdom. ";
            recitation_6 = "Recitation: “We must show prudent moderation and diligent control over our desires.” Temperance is exemplified by self-restraint in all facets, particularly regular fasting and avoidance of intoxicants.";
            blessing_7 = "The Seventh Virtue is Chastity, which reinforces Temperance. ";
            recitation_7 = "Recitation: “We must control our passions as to avoid distraction from God’s holiness.” Chastity is the sacrifice of sexual pleasure to demonstrate devotion, through abstinence and marital fidelity.";
            blessing_8 = "The Eighth Virtue is Charity, which echoes Justice. ";
            recitation_8 = "Recitation: “We must show compassion to those worthy of God’s mercy.” Charity is exemplified by philanthropic acts and outreach to faithful sufferers.";
            blessing_9 = "The Ninth Virtue is Integrity, which echoes Propriety. ";
            recitation_9 = "Recitation: “We must honor our oaths and uphold the truth.” Integrity is exemplified by unfailing honesty and the exposure of deviants, as well as regular confession of our failings.";
            blessing_10 = "The Tenth Virtue is Hope, which echoes Faith. ";
            recitation_10 = "Recitation: “We must never despair, no matter how dark the hour, as God shines their light upon us.”  Hope is exemplified by the conquest of despair, symbolized most prominently by the restriction of mourning to a designated period, as well as the teaching of the Virtues to the ignorant.";
        }
    }
}