using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChampionsLeague
{
    public class Data
    {
        private ObservableCollection<Ploeg> ploegen;

        public ObservableCollection<Ploeg> Ploegen
        {
            get { return ploegen; }
        }

        public Data()
        {
            ploegen = new ObservableCollection<Ploeg>();

            ploegen.Add(new Ploeg(10, "Arsenal FC", "Arsenal.png", "England", "Group A", "Arsenal's reputation as dour but effective changed radically with the arrival of little-known French manager Arsène Wenger in October 1996. Putting the accent on fluid, attacking football, 'Le Professeur' led the Gunners to three Premier League crowns and four FA Cup wins, not least guiding the so-called 'Invincibles' through an unbeaten Premier League campaign in 2003/04. Wenger also took the club to their first UEFA Champions League final in 2005/06, and masterminded the move from Highbury to their current stadium."));
            ploegen.Add(new Ploeg(52, "FC Barcelona", "Barcelona.png", "Spain", "Group B", "Frank Rijkaard led the side to back-to-back Liga titles and goals from Samuel Eto'o and Juliano Belletti earned UEFA Champions League glory over Arsenal FC in 2006. Better was yet to come, however, as Josep Guardiola guided Barcelona to an unprecedented six trophies in 2009, following that up with Liga successes in 2010 and 2011. A third European Cup in five years was won with victory against Manchester United FC at Wembley in 2011."));
            ploegen.Add(new Ploeg(54, "FC Bayern München", "Bayern.png", "Germany", "Group C", "Bayern more than made up for those disappointments in 2012/13, breaking all manner of records en route to the title, defeating Borussia Dortmund in the UEFA Champions League final and, after victory against VfB Stuttgart in the German Cup showpiece, becoming the first German club to complete the treble."));
            ploegen.Add(new Ploeg(63, "Chelsea FC", "Chelsea.png", "England", "Group A", "Villas-Boas did not last the season, but while league results were a disappointment, stand-in boss Roberto di Matteo led the Blues to their seventh FA Cup and then UEFA Champions League glory, beating FC Bayern München on penalties at their own stadium after a 1-1 draw. Di Matteo was replaced himself in November 2013 and though temporary successor Rafael Benítez could not prevent the Londoners becoming the first holders to be eliminated in the UEFA Champions League group stage, he guided them to victory in the UEFA Europa League final six months later."));

            ploegen.Add(new Ploeg(56, "FC Internazionale Milano", "Internazionale.png", "Italy", "Group C", "Declared bankrupt in 2004, a new owner and president − film producer Aurelio De Laurentiis − helped the club start from scratch in Serie C1, and they were back in the top division by 2007/08, returning to Europe after a 14-year absence in the 2008 UEFA Intertoto Cup. In 2013, Walter Mazzarri's team finished second in Serie A, the Partenopei's best performance since winning the Scudetto in 1990."));
            ploegen.Add(new Ploeg(85, "FC København", "Kobenhavn.png", "Denmark", "Group A", "The Violets collected three straightcrowns from 1991–93 and closed a barren decade by landing a league and cup double in 2003. After a seven-year sabbatical, Peter Stöger returned to the dugout for the 2012/13 season and steered them to their 24th title, receiving acclaim for his eye-catching brand of football."));
            ploegen.Add(new Ploeg(963, "Olympique Lyonnais", "Lyon.png", "France", "Group C", "Lyon reached the UEFA Champions League quarter-finals three years running between 2004 and 2006 and surpassed that feat in 2009/10, losing against FC Bayern München in the last four."));
            ploegen.Add(new Ploeg(154, "Manchester United FC", "ManUnited.png", "England", "Group D", "After bringing in Eric Cantona, Sir Alex's team ended a 26-year wait by claiming an eighth league title in the inaugural Premier League season of 1992/93. The new competition suited United, who went on to become a hugely dominant force in the domestic game while returning to the European summit in their treble-winning 1998/99 campaign and again in 2007/08. By winning the league for the 19th time in 2010/11, the Red Devils surpassed Liverpool FC as the most successful club in English football."));

            ploegen.Add(new Ploeg(65, "Olympique de Marseille", "Marseille.png", "France", "Group D", "Celebrations were short-lived. Found guilty of match-fixing, Marseille were demoted to the second tier and stripped of the 1992/93 French title. Though they soon bounced back, major silverware proved elusive. OM reached two UEFA Cup finals but lost both, to Parma FC (1999) and Valencia CF (2004), and it was a similar story in the French Cup finals of 2006 and 2007. The curse was finally lifted in 2009/10 as they followed up their maiden League Cup success with a first title since 1992."));
            ploegen.Add(new Ploeg(130, "AC Milan", "Milan.png", "Italy", "Group C", "Sacchi protégé Carlo Ancelotti became coach in November 2001 and took Milan to another Scudetto and two UEFA Champions League titles. In 2003 captain Paolo Maldini lifted the European Cup in England 40 years after his father had done the same. Four years later the Rossoneri atoned for their defeat on penalties by Liverpool FC in the 2005 final by beating them in Athens to clinch the trophy for a seventh time. Milan appointed Massimiliano Allegri as coach in 2010 and he enjoyed success in his debut season, securing the Diavolo's first Scudetto since 2004."));
            ploegen.Add(new Ploeg(8, "Real Madrid CF", "RealMadrid.png", "Spain", "Group A", "The likes of Ronaldo, Luís Figo and Zinédine Zidane led Madrid to a ninth European Cup in 2001/02, the latter scoring a memorable winner to see off Bayer 04 Leverkusen 2-1 in Glasgow. The combination of €94m, world-record signing Cristiano Ronaldo and coach José Mourinho raised the stakes again, with that duo spearheading Madrid's charge for the club's 32nd Spanish title in 2012."));
            ploegen.Add(new Ploeg(541, "AS Roma", "Roma.png", "Italy", "Group B", "In 2011/12, the club celebrated by taking their first title since 2003, with Antonio Conte's side finishing the campaign unbeaten. The Bianconeri retained the Scudetto the following season."));

            ploegen.Add(new Ploeg(123, "FC Schalke 04", "Schalke.png", "Germany", "Group D", "Schalke's seven titles are behind only FC Bayern München (22) and 1. FC Nürnberg (9) in the all-time rankings, but all those successes were before the advent of the Bundesliga; they have finished second in the table six times, most recently in 2009/10."));
            ploegen.Add(new Ploeg(201, "FC Shakhtar Donetsk", "ShaktarDonetsk.png", "Ukraine", "Group B", "In 2011, Shakhtar broke new ground by reaching the UEFA Champions League quarter-finals, where they lost to eventual winners FC Barcelona. Winners of the domestic double, they repeated the feat in 2011/12 and 2012/13."));
            ploegen.Add(new Ploeg(1, "Tottenham Hotspur FC", "Tottenham.png", "England", "Group D", "In 2011, Roberto Mancini led Tottenham to FA Cup glory as well as a third-place finish, which secured UEFA Champions League football for the first time in the club's history. Better was to follow as they took the 2012 title – their first since 1968 – holding off Manchester United FC thanks to Sergio Agüero's late winner against Queens Park Rangers FC."));
            ploegen.Add(new Ploeg(101, "Valencia CF", "Valencia.png", "Spain", "Group B", "The arrival of Diego Simeone in December 2011 began a new era of success, with the Argentinian – a former Liga and cup double-winning midfielder with Atlético – guiding Los Colchoneros to UEFA Europa League, UEFA Super Cup and Copa del Rey glory, as well as UEFA Champions League qualification in little over a year."));
        }

        public Ploeg GetPloegById(int id)
        {
            Ploeg resultaat = ploegen.First(
                delegate(Ploeg ploeg)
                {
                    return ploeg.Id == id;
                }
            );

            return resultaat;
        }

    }
}
