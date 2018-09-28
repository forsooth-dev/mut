﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Data;

namespace WebApplication8.Models
{
    public class Roles
    {
        public Stats StrikerQuick = new Stats
        {
            acceleration = 5,
            sprintSpeed = 4.5,
            positioning = 2,
            finishing = 2,
            shotPower = 1,
            longShots = 1,
            volleys = 0.5,
            penalties = .2,
            vision = 1.5,
            crossing = 0.5,
            freekickaccuracy = 0.1,
            shortPassing = 1.5,
            longPassing = 0.5,
            curve = 0.5,
            agility = 1.8,
            balance = 1.5,
            reactions = 1.2,
            ballControl = 1.5,
            dribbling = 1.5,
            composure = 2,
            interceptions = .3,
            headingAccuracy = .5,
            marking = 0.1,
            standingTackle = .1,
            slidingTackle = .1,
            jumping = 1,
            stamina = 2,
            strength = 2,
            aggression = .2
        };
        public Stats StrikerStrong = new Stats
        {
            acceleration = 1.5,
            sprintSpeed = 1.8,
            positioning = 2,
            finishing = 1.8,
            shotPower = 1.2,
            longShots = 1.5,
            volleys = 0.2,
            penalties = .2,
            vision = 1,
            crossing = 0.2,
            freekickaccuracy = 0.1,
            shortPassing = 1,
            longPassing = 0.3,
            curve = 0.3,
            agility = 1,
            balance = 1,
            reactions = 1,
            ballControl = .8,
            dribbling = .8,
            composure = 2,
            interceptions = .2,
            headingAccuracy = 3.5,
            marking = 0.1,
            standingTackle = .1,
            slidingTackle = .1,
            jumping = .5,
            stamina = 1.2,
            strength = 6,
            aggression = .2
        };
        public Stats StrikerSkilled = new Stats
        {
            acceleration = 3.5,
            sprintSpeed = 3.5,
            positioning = 2.5,
            finishing = 2.2,
            shotPower = 1.8,
            longShots = 2,
            volleys = 1.5,
            penalties = 1,
            vision = 2,
            crossing = 0.8,
            freekickaccuracy = 0.5,
            shortPassing = 1.8,
            longPassing = 1,
            curve = 1,
            agility = 1.2,
            balance = 1,
            reactions = 1,
            ballControl = 1,
            dribbling = 1,
            composure = 2.2,
            interceptions = .2,
            headingAccuracy = 1.5,
            marking = 0.1,
            standingTackle = .1,
            slidingTackle = .1,
            jumping = 1,
            stamina = 2,
            strength = 2.5,
            aggression = .2
        };
        public Stats WingerQuick = new Stats
        {
            acceleration = 5,
            sprintSpeed = 4.5,
            positioning = 1.5,
            finishing = 1.2,
            shotPower = 1,
            longShots = 1,
            volleys = .5,
            penalties = .1,
            vision = 2,
            crossing = 1.5,
            freekickaccuracy = .1,
            shortPassing = 1.2,
            longPassing = .8,
            curve = .3,
            agility = 2,
            balance = 1.8,
            reactions = 1.5,
            ballControl = 1.8,
            dribbling = 1.8,
            composure = 2,
            interceptions = .2,
            headingAccuracy = .5,
            marking = 0.1,
            standingTackle = .1,
            slidingTackle = .1,
            jumping = .5,
            stamina = 2.5,
            strength = 2,
            aggression = .2
        };
        public Stats WingerSkilled = new Stats
        {
            acceleration = 5,
            sprintSpeed = 4.5,
            positioning = 1.5,
            finishing = 1.2,
            shotPower = 1,
            longShots = 1,
            volleys = .5,
            penalties = .1,
            vision = 2,
            crossing = 1.5,
            freekickaccuracy = .1,
            shortPassing = 1.2,
            longPassing = .8,
            curve = .3,
            agility = 2,
            balance = 1.8,
            reactions = 1.5,
            ballControl = 1.8,
            dribbling = 1.8,
            composure = 2,
            interceptions = .2,
            headingAccuracy = .5,
            marking = 0.1,
            standingTackle = .1,
            slidingTackle = .1,
            jumping = .5,
            stamina = 2.5,
            strength = 2,
            aggression = .2
        };
        public double CalculateRole(FutPlayers player, Stats statModel)
        {
            double total = 0;
            // Pace
            total += player.acceleration * statModel.acceleration;
            total += player.sprintSpeed * statModel.sprintSpeed;
            // Shooting
            total += player.positioning * statModel.positioning;
            total += player.finishing * statModel.finishing;
            total += player.shotPower * statModel.shotPower;
            total += player.longShots * statModel.longShots;
            total += player.volleys * statModel.volleys;
            total += player.penalties * statModel.penalties;
            // Passing
            total += player.vision * statModel.vision;
            total += player.crossing * statModel.crossing;
            total += player.freekickaccuracy * statModel.freekickaccuracy;
            total += player.shortPassing * statModel.shortPassing;
            total += player.longPassing * statModel.longPassing;
            total += player.curve * statModel.curve;
            // Dribbling
            total += player.agility * statModel.agility;
            total += player.balance * statModel.balance;
            total += player.reactions * statModel.reactions;
            total += player.ballControl * statModel.ballControl;
            total += player.dribbling * statModel.dribbling;
            total += player.composure * statModel.composure;
            // Defending
            total += player.interceptions * statModel.interceptions;
            total += player.headingAccuracy * statModel.headingAccuracy;
            total += player.marking * statModel.marking;
            total += player.stamina * statModel.stamina;
            total += player.slidingTackle * statModel.slidingTackle;
            // Physical
            total += player.jumping * statModel.jumping;
            total += player.stamina * statModel.stamina;
            total += player.strength * statModel.strength;
            total += player.aggression * statModel.aggression;
            return total;
        }
    }

    public class StatPair
    {
        public FutPlayers player { get; set; }
        public double statTotal { get; set; }
        public string tier { get; set; }
    }

    

    public class Stats
    {
        public double acceleration { get; set; }
        public double sprintSpeed { get; set; }
        public double positioning { get; set; }
        public double finishing { get; set; }
        public double shotPower { get; set; }
        public double longShots { get; set; }
        public double volleys { get; set; }
        public double penalties { get; set; }
        public double vision { get; set; }
        public double crossing { get; set; }
        public double freekickaccuracy { get; set; }
        public double shortPassing { get; set; }
        public double longPassing { get; set; }
        public double curve { get; set; }
        public double agility { get; set; }
        public double balance { get; set; }
        public double reactions { get; set; }
        public double ballControl { get; set; }
        public double dribbling { get; set; }
        public double composure { get; set; }
        public double interceptions { get; set; }
        public double headingAccuracy { get; set; }
        public double marking { get; set; }
        public double standingTackle { get; set; }
        public double slidingTackle { get; set; }
        public double jumping { get; set; }
        public double stamina { get; set; }
        public double strength { get; set; }
        public double aggression { get; set; }
    }
}
