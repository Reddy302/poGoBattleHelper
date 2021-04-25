using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoGoBattleHelper.Models
{
    public class Pokemon
    {
        public int Dex { get; set; }
        public string Name { get; set; }
        public float[] AnimationTime { get; set; }
        public float Height { get; set; }
        public float ModelHeight { get; set; }
        public int KmBuddyDistance { get; set; }
        public float Weight { get; set; }
        public float ModelScale { get; set; }
        public int MaxCP { get; set; }
        public Buddysize BuddySize { get; set; }
        public CinematicMove[] CinematicMoves { get; set; }
        public QuickMove[] QuickMoves { get; set; }
        public Family Family { get; set; }
        public Stats Stats { get; set; }
        public Type[] Types { get; set; }
        public Encounter Encounter { get; set; }
        public Camera Camera { get; set; }
        public Evolution Evolution { get; set; }
        public string Id { get; set; }
        public object[] Forms { get; set; }
    }

    public class Buddysize
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Family
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class Stats
    {
        public int BaseAttack { get; set; }
        public int BaseDefense { get; set; }
        public int BaseStamina { get; set; }
    }

    public class Encounter
    {
        public float AttackProbability { get; set; }
        public int AttackTimer { get; set; }
        public float BaseFleeRate { get; set; }
        public float BaseCaptureRate { get; set; }
        public float CameraDistance { get; set; }
        public float CollisionRadius { get; set; }
        public float DodgeDistance { get; set; }
        public float DodgeProbability { get; set; }
        public float JumpTime { get; set; }
        public float MaxPokemonActionFrequency { get; set; }
        public float MinPokemonActionFrequency { get; set; }
        public MovementType MovementType { get; set; }
        public Gender Gender { get; set; }
    }

    public class MovementType
    {
        public string Name { get; set; }
        public string Id { get; set; }
    }

    public class Gender
    {
        public float MalePercent { get; set; }
        public float FemalePercent { get; set; }
    }

    public class Camera
    {
        public float CylinderRadius { get; set; }
        public float DiskRadius { get; set; }
        public float ShoulderModeScale { get; set; }
    }

    public class Evolution
    {
        public FutureBranch[] FutureBranches { get; set; }
    }

    public class FutureBranch
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public FutureBranch1[] FutureBranches { get; set; }
        public CostToEvolve CostToEvolve { get; set; }
    }

    public class CostToEvolve
    {
        public int CandyCost { get; set; }
    }

    public class FutureBranch1
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public CostToEvolve1 CostToEvolve { get; set; }
    }

    public class CostToEvolve1
    {
        public int CandyCost { get; set; }
    }
}