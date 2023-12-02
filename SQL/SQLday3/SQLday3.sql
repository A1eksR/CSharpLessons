SELECT artists.Name, artists.ArtistId
FROM artists;

SELECT artists.Name, artists.ArtistId, albums.AlbumId, albums.Title, albums.ArtistId
FROM artists, albums
WHERE artists.ArtistId = albums.ArtistId;

SELECT artists.ArtistId, albums.ArtistId, tracks.AlbumId
FROM artists
INNER JOIN albums
ON artists.ArtistId = tracks.AlbumID
INNER JOIN albums
ON albums.AlbumId = tracks.AlbumId;
