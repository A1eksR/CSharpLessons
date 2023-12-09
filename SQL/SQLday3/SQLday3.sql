SELECT artists.Name, artists.ArtistId
FROM artists;

SELECT artists.Name, artists.ArtistId, albums.AlbumId, albums.Title, albums.ArtistId
FROM artists, albums
WHERE artists.ArtistId = albums.ArtistId;

SELECT artists.ArtistId, albums.ArtistId, tracks.AlbumId
FROM artists
INNER JOIN albums 
ON artists.ArtistId = albums.ArtistId
INNER JOIN tracks 
ON albums.AlbumId = tracks.AlbumId
ORDER BY artists.Name DESC;

SELECT tracks.TrackId, playlists.PlaylistId, playlist_track.TrackId
FROM tracks
INNER JOIN playlist_track
ON tracks.TrackId = playlist_track.TrackId
INNER JOIN playlists
ON playlist_track.PlaylistId = playlists.PlaylistId

SELECT employees.FirstName
FROM employees

SELECT genres.Name
FROM genres

