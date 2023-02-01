﻿using Application.Interfaces.Repositories.API;
using Application.Interfaces.Repositories.SQL;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Requests.TrainingCenters
{
    class GetTrainingCenterLetterByTrainingCenterIdApiRequestHandler : IRequestHandler<GetTrainingCenterLetterByTrainingCenterIdApiRequest, ActionResult<char?>>
    {
        private readonly ITrainingCentersAPIRepository _repository;

        public GetTrainingCenterLetterByTrainingCenterIdApiRequestHandler(ITrainingCentersAPIRepository repository)
        {
            _repository = repository;
        }

        public async Task<ActionResult<char?>> Handle(GetTrainingCenterLetterByTrainingCenterIdApiRequest request, CancellationToken cancellationToken)
        {
            char? letter = await _repository.GetLetterById(request.TrainingCenterID);

            if(letter == null)
            {
                return request.Controller.Ok(String.Empty);
            }

            return request.Controller.Ok(letter);
        }
    }
}
