# Database
![Database Diagram](DatabaseDiagram.svg)

 ## Table `Users`
 Stores users data.

| Column         | Type              | Description                  |
|----------------|-------------------|------------------------------|
| `UserId`       | INT (PK) Not Null | User unique identifier       |
| `UserLogin`    | VARCHAR(255)      | User login                   |
| `UserPassword` | VARCHAR(255)      | User Password                |
| `AccountDate`  | Date              | Date when accout was created |

 ## Table `UserScoreData`
 Stores user game score and data.

| Column          | Type              | Description                                |
|-----------------|-------------------|--------------------------------------------|
| `ScoreId`       | INT (PK) Not Null | Score unique identifier                    |
| `UserId`        | INT (FK)          | User id which gave a score                 |
| `GameId`        | INT (FK)          | Game id which score was given              |
| `GameStatus`    | VARCHAR(255)      | Game status like completed/playing/dropped |
| `TimePlayed`    | INT               | How much time game was played (in h)       |
| `GameplayScore` | INT               | Score for gameplay aspect (0-1)            |
| `StoryScore`    | INT               | Score for story aspect (0-1)               |
| `GraphicScore`  | INT               | Score for graphic aspect (0-1)             |
| `AudioScore`    | INT               | Score for audio aspect (0-1)               |
| `QualityScore`  | INT               | Score for quality aspect (0-1)             |
| `SumScore`      | INT               | Sum of all scores (0-5)                    |

 ## Table `Games`
Stores games data.

| Column         | Type              | Description            |
|----------------|-------------------|------------------------|
| `GameId`       | INT (PK) Not Null | Game unique identifier |
| `GameName`     | VARCHAR(255)      | Name of a game         |
| `GameGenre`    | VARCHAR(255)      | Genre of a game        |