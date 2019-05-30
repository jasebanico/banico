import { Component, OnInit } from '@angular/core';
import { Subforum } from '../../entities/subforum';
import { SubforumService } from '../../services/subforum.service';
import { TopicService } from '../../services/topic.service';
import { ActivatedRoute } from '@angular/router';
import { Observable } from 'rxjs';
import { Topic } from '../../entities/topic';
import { SubforumEntityService } from '../../services/subforum-entity.service';

@Component({
  selector: 'app-subforum',
  templateUrl: './subforum.component.html',
  styleUrls: ['./subforum.component.scss']
})
export class SubforumComponent implements OnInit {
  //public subforum$: Observable<Subforum>;
  public subforum: Subforum;
  public topics: Topic[];

  constructor(
    //private subforumEntityService: SubforumEntityService,
    private subforumService: SubforumService,
    private topicService: TopicService,
    private route: ActivatedRoute
    ) {
  }

  ngOnInit() {
    this.route.params.subscribe(params => {
      if (params['alias']) {
        var alias = params['alias'];
        this.subforumService.getByAlias(alias)
          .subscribe(subforum => {
            this.set(subforum);
          });
        }
    });
  }

  private set(subforum: Subforum) {
    this.subforum = subforum;
    this.topicService.getTopics(subforum.id)
      .subscribe(topics => this.topics = topics);
  }

}