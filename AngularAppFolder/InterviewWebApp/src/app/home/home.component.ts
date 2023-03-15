import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { QuestionsService } from '../_services/questions.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {

  questions;
  error;
  constructor(
    private httpService: HttpClient,
    private questionsService: QuestionsService
  ) { 

  }

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
}
