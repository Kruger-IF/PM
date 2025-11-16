Localizacao pos = new Localizacao { Latitude = 0, Longitude = 0 };

Mover mover = new Mover();

mover.VerPos(ref pos);

mover.Norte(ref pos, 20);

mover.Sul(ref pos, 15);

mover.Leste(ref pos, 20);

mover.Oeste(ref pos, 15);

mover.Norte(ref pos, 91);

mover.Leste(ref pos, 190);





