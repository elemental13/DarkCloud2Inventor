insert into inventions_have_inventtypes values(1, 1);

insert into inventions_have_items values(1, 1, 4);
insert into inventions_have_items values(1, 2, 4);
insert into inventions_have_items values(1, 3, 2);

insert into inventions_have_photos values(1, 33);
insert into inventions_have_photos values(1, 135);
insert into inventions_have_photos values(1, 249);

insert into inventtypes values(1, 'Footwear');
insert into inventtypes values(2, 'Items');
insert into inventtypes values(3, 'Ridepod Parts');
insert into inventtypes values(4, 'Weapons');

insert into items values(1, 'Sturdy Cloth', 20);
insert into items values(2, 'Wind Crystal', 150);
insert into items values(3, 'Thick Hide', 50);

insert into photos values(33, 'Cloth', 2, 'Parn''s Studio, on the floor', 'cloth.png');
insert into photos values(135, 'Parasol', 1, 'Palm Brinks, umbrellas over tables', 'parasol.png');
insert into photos values(249, 'Clown Robo''s Attack', 1, 'Found at: Underground Channel, with eye open to shoot missile
  Scoop Memo: Catch that horrifying moment when the Clown Robo launches its
    missiles.  But watch out ''cause you won''t have much time!
  Missable: Only during boss battle', 'clownrobosattack.png');

insert into photos_have_phototypes values(33, 1);
insert into photos_have_phototypes values(135, 1);
insert into photos_have_phototypes values(249, 1);

insert into photostaken values('Brandon', 33);

insert into phototypes values(1, 'Idea');
insert into phototypes values(2, 'Scoops');