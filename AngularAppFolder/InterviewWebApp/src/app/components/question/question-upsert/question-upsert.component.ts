import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { QuestionsService } from 'src/app/_services/questions.service';

@Component({
  selector: 'app-question-upsert',
  templateUrl: './question-upsert.component.html',
  styleUrls: ['./question-upsert.component.css']
})
export class QuestionUpsertComponent implements OnInit {

  questionId: any;
  upsertQuestionForm: FormGroup;
  //questionText = new FormControl('');
  constructor(private activateRouteService: ActivatedRoute, private formBuilder: FormBuilder, private questionService: QuestionsService, private router: Router) {
    
  }

  ngOnInit(): void {
    this.activateRouteService.queryParams.subscribe(param => {
      this.questionId = param['id'];
    });
    if(this.questionId && this.questionId != '0') {
      //Edit Mode
      this.questionService.getQuestion(this.questionId).subscribe({
        //next (paso exitoso)
        next: question => {
          console.log(question);
          this.upsertQuestionForm = this.formBuilder.group({
            descripcion: [question['description'], Validators.required]
          })   
        },
        //error (paso erroneo)
        error: error => console.log(error),
        //complete (paso sí o sí)
        complete: () => console.log("complete")
      });
    }
    else {
      //Create Mode
      this.upsertQuestionForm = this.formBuilder.group({
        descripcion: ['', Validators.required]
      })      
    }
    
  }

  onSubmit(){
    const question = this.upsertQuestionForm.value;
    if(this.upsertQuestionForm.valid) {
      console.log(question);
      if(this.questionId && this.questionId != '0') {
        //Edit Mode
        this.questionService.editQuestion(this.questionId, question).subscribe({
          //next (paso exitoso)
          next: question => this.router.navigate(['/questions']),
          //error (paso erroneo)
          error: error => console.log(error),
          //complete (paso sí o sí)
          complete: () => console.log("complete")
        });
      }
      else {
        //Create Mode
        this.questionService.addQuestion(question).subscribe({
          //next (paso exitoso)
          next: question => this.router.navigate(['/questions']),
          //error (paso erroneo)
          error: error => console.log(error),
          //complete (paso sí o sí)
          complete: () => console.log("complete")
        });        
      }
      
    }
  }
}
