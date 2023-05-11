using HCP.Config.DL.Repository;
using HCP.Config.DO;
using HCP.Config.IF;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace HCP.Config.WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class VoucherController : ControllerBase
    {
        private readonly IVoucherRepository _VoucherRepository;

        public VoucherController(IVoucherRepository voucherRepository)
        {
            _VoucherRepository = voucherRepository;
        }

        #region Voucher Related Methods

        #region Payment Mode
        /// <summary>
        /// Getting Payment Mode and payment Mode Category dropdown.
        /// UI Reffered - Payment Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetApplicationCodesByCodeType(int codeType)
        {
            var pay_modes = await _VoucherRepository.GetApplicationCodesByCodeType(codeType);
            return Ok(pay_modes);
        }


        /// <summary>
        /// Getting Payment Mode List.
        /// UI Reffered - Payment Mode Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetPaymentModes()
        {
            var _modes = await _VoucherRepository.GetPaymentModes();
            return Ok(_modes);
        }
        /// <summary>
        /// Insert Payment Mode.
        /// UI Reffered -Payment Mode
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertOrUpdatePaymentMode(DO_PaymentMode obj)
        {
            var msg = await _VoucherRepository.InsertOrUpdatePaymentMede(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Active Or De Active Payment Mode .
        /// UI Reffered -Payment Mode 
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActivePaymentMode(DO_PaymentMode obj)
        {
            var msg = await _VoucherRepository.ActiveOrDeActivePaymentMode(obj);
            return Ok(msg);

        }
        #endregion Payment

        #region Transaction Type
        /// <summary>
        /// Getting Payment Voucher List.
        /// UI Reffered - Payment Voucher Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetPaymentVouchers()
        {
            var _vouchers = await _VoucherRepository.GetPaymentVouchers();
            return Ok(_vouchers);
        }
        /// <summary>
        /// Insert Payment Voucher .
        /// UI Reffered -Payment Voucher
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoPaymentVoucher(DO_PaymentVoucher obj)
        {
            var msg = await _VoucherRepository.InsertIntoPaymentVoucher(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update Payment Voucher.
        /// UI Reffered -Payment Voucher
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> UpdatePaymentVoucher(DO_PaymentVoucher obj)
        {
            var msg = await _VoucherRepository.UpdatePaymentVoucher(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active Or De Active Payment Voucher
        /// UI Reffered - Payment Voucher
        /// </summary>
        /// <param name="status-voucherId"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> ActiveOrDeActivePaymentVoucher(bool status, int voucherId)
        {
            var msg = await _VoucherRepository.ActiveOrDeActivePaymentVoucher(status, voucherId);
            return Ok(msg);
        }
        #endregion Document Control

        #region Mapping

        /// <summary>
        /// Getting Active Payments for drop down.
        /// UI Reffered - Voucher Link 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActivePaymentModes()
        {
            var _methods = await _VoucherRepository.GetActivePaymentModes();
            return Ok(_methods);
        }

        /// <summary>
        /// Getting Active Vouchers for drop down.
        /// UI Reffered - Voucher Link 
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetActiveVouchers()
        {
            var _vouchers = await _VoucherRepository.GetActiveVouchers();
            return Ok(_vouchers);
        }

        /// <summary>
        /// Getting Linked vouchers with payments for Grid.
        /// UI Reffered - Voucher Link Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetPaymentLinkedVouchers()
        {
            var link_vouchers = await _VoucherRepository.GetPaymentLinkedVouchers();
            return Ok(link_vouchers);
        }

        /// <summary>
        /// Insert Form Link with documents .
        /// UI Reffered -Voucher Link
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoPaymentVoucherLink(DO_PaymentVoucherLink obj)
        {
            var msg = await _VoucherRepository.InsertIntoPaymentVoucherLink(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Delete vouchers Link with payments .
        /// UI Reffered -Voucher Link
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> DeletePaymentLinkedVoucher(int voucherId, int paymentId)
        {
            var msg = await _VoucherRepository.DeletePaymentLinkedVoucher(voucherId, paymentId);
            return Ok(msg);

        }
        #endregion Payment LINK TO Voucher

        #region Voucher Generation
        /// <summary>
        /// Getting Voucher Generation List.
        /// UI Reffered - Voucher Generation Grid
        /// </summary>
        [HttpGet]
        public async Task<IActionResult> GetVoucherGenerationsbyBusinesskey(int businesskey)
        {
            var _vgen = await _VoucherRepository.GetVoucherGenerationsbyBusinesskey(businesskey);
            return Ok(_vgen);
        }
        /// <summary>
        /// Insert Voucher Generation.
        /// UI Reffered -Voucher Generation
        /// </summary>
        [HttpPost]
        public async Task<IActionResult> InsertIntoVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _VoucherRepository.InsertIntoVoucherGeneration(obj);
            return Ok(msg);

        }
        /// <summary>
        /// Update Voucher Generation.
        /// UI Reffered -Voucher Generation
        [HttpPost]
        public async Task<IActionResult> UpdateVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _VoucherRepository.UpdateVoucherGeneration(obj);
            return Ok(msg);

        }

        /// <summary>
        /// Active Or De Active Voucher Generation
        /// UI Reffered - Voucher Generation
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> ActiveOrDeActiveVoucherGeneration(DO_VoucherGeneration obj)
        {
            var msg = await _VoucherRepository.ActiveOrDeActiveVoucherGeneration(obj);
            return Ok(msg);
        }
        #endregion Voucher Generation

        #endregion
    }
}