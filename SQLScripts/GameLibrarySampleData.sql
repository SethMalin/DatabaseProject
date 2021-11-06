USE GameLibrary
GO

INSERT INTO Game (Title, Genre, Rating, Director, Composer, Artist, Company, [Year], Console)
VALUES
('Super Mario Bros', 'Platformer', 'E', 'Shigeru Miyamoto', 'Koji Kondo', null, 'Nintendo', '1986', 'NES'),
('Donkey Kong Country', 'Platformer', 'E', 'Stamper Brothers', 'DavGameID Wise', null, 'Nintendo', '1994', 'SNES'),
('Conkers Bad Fur Day', 'Platformer', 'M', 'Chris Seavor', 'Robin Beanland', null, 'Rare', '2001', 'N64'),
('Final Fantasy', 'RPG', 'E', 'Hironobu Sakaguchi', 'Nobuo Uematsu', 'Yoshitaka Amano', 'Square', '1987', 'NES')


SELECT *
FROM Game
