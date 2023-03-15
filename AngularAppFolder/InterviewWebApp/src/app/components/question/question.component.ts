import { Component, OnInit } from '@angular/core';
import { QuestionsService } from 'src/app/_services/questions.service';

@Component({
  selector: 'app-question',
  templateUrl: './question.component.html',
  styleUrls: ['./question.component.css']
})
export class QuestionComponent implements OnInit {

  questions;
  error;
  columnsToDisplay = ['id', 'description', 'actions'];
  constructor(
    private questionsService: QuestionsService
  ) { }

  ngOnInit(): void {
    this.getQuestions();
  }

  getQuestions(){
    this.questionsService.getQuestions().subscribe({
      next: (result) => { 
        console.log(result);
        this.questions = result;
      },
      error: (error) => { 
        console.log(error);
        this.error = error;
      },
      complete: () => { 
        //console.log("complete");
      }
    })
  }

  refresh(){
    this.getQuestions();
  }

  DeleteQuestion(id: number) {
    this.questionsService.deleteQuestion(id).subscribe({
      next: (result) => { 
        console.log(result);
        this.getQuestions();
      },
      error: (error) => { 
        console.log(error);
        this.error = error;
      },
      complete: () => { 
        //console.log("complete");
      }
    })
  }
}
