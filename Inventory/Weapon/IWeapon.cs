public interface IWeapon {
    float damage {get; set;}
    string name {get; set;}
    string description {get; set;}
    Texture2D texture {get;set;}

    float dealDamage(ICharacter opponent);
    bool breakWeapon();
}
