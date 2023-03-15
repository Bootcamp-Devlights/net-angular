import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class QuestionsService {
  baseUrl = environment.baseUrl + "questions/";

  constructor(private httpService: HttpClient) { }

  getQuestions(){
    return this.httpService.get(this.baseUrl)
  }

  getQuestion(id: number){
    return this.httpService.get(this.baseUrl + id)
  }

  addQuestion(question: any){
    return this.httpService.post(this.baseUrl, question)
  }

  editQuestion(id: number, question: any){
    return this.httpService.put(this.baseUrl + id, question)
  }

  deleteQuestion(id: number){
    return this.httpService.delete(this.baseUrl + id)
  }
}
