SELECT artists.Name, artists.ArtistId
FROM artists;

SELECT artists.Name, artists.ArtistId, albums.AlbumId, albums.Title, albums.ArtistId
FROM artists, albums
WHERE artists.ArtistId = albums.ArtistId;

SELECT artists.ArtistId, albums.ArtistId, tracks.AlbumId
FROM artists, albums, tracks
ON artists.ArtistId = albums.ArtistId;
