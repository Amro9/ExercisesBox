import { DifficultyLevel } from "./DifficutlyLevel";


export class Question {
    id: string;
    author: string;
    questionText: string;
    answer: string;
    schoolLevel: string;
    difficultyLevelDto: DifficultyLevel;
    subject: string;
    topic: string;

    constructor(id: string, author: string, questionText: string, answer: string, schoolLevel: string, difficultyLevelDto: DifficultyLevel, subject: string, topic: string){
        this.id = id;
        this.author = author;
        this.questionText = questionText;
        this.answer = answer;
        this.schoolLevel = schoolLevel;
        this.difficultyLevelDto = difficultyLevelDto;
        this.subject = subject;
        this.topic = topic;
    }

    static fromJSON(json: any): Question {
        return new Question(
            json.id,
            json.author,
            json.questionText,
            json.answer,
            json.schoolLevel,
            json.difficultyLevelDto,
            json.subject,
            json.topic
        );
    }
}