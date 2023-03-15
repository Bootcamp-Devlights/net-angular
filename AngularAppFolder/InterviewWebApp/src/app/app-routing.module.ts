import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './components/login/login.component';
import { QuestionUpsertComponent } from './components/question/question-upsert/question-upsert.component';
import { QuestionComponent } from './components/question/question.component';
import { RegisterComponent } from './components/register/register.component';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './_guards/auth.guard';

const routes: Routes = [
  { path: '', runGuardsAndResolvers: 'always', canActivate: [AuthGuard], children: [
    {
      path: 'home',
      component: HomeComponent
    },
    {
      path: 'questions',
      component: QuestionComponent
    },
    {
      path: 'questions/upsert',
      component: QuestionUpsertComponent
    },
  ]},
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
