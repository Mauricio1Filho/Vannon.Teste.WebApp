﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Vannon.Teste.WebApp.Domain.Repositories
{
    public interface IReservaRepository
    {
        Task<bool> ReservarFilmeAsync(long idFilme, long idUsuario);
        Task<bool> RemoverReservaAsync(long idReserva);
    }
}