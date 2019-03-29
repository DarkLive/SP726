USE Blog
GO
CREATE VIEW	ListEntriesWithAuthorName
AS 
SELECT Article.artID, Article.artAuthor, Author.autName, Article.artDate, Article.artTitle, Article.artText FROM Article 
INNER JOIN Author ON Article.artAuthor = Author.autID
GO